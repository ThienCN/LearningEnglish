$(document).ready(function () {
    $('#myModal').on('shown.bs.modal', function () {
        $('#sound')[0].play();
    })
})

function sleep(ms) {
    return new Promise(resolve => setTimeout(resolve, ms));
}

var k = 0;
var pos1 = 0;
var pos2 = 0;
var complete = 0;
async function changeImage( src, index) {
    $this = index;
    var clicked = $this;
    if (clicked.attr("data-mode") == 0) {
        clicked.attr("src", src);
        COMMON.Audio.AutoStart("sound", clicked.attr("data-sound"));

    }
    else if (clicked.attr("data-mode") == 1) {
        clicked.attr("src", "//");
        var divText = $(clicked).parent().find(".text");
        divText.removeAttr("hidden");
        COMMON.Audio.AutoStart("sound", clicked.attr("data-pronounce"));

    }
    k++;
    if (k == 1) {
        pos1 = clicked; // Luu lai vi tri anh 1
    }
    if (k == 2) {
        $(".square").css("pointer-events", "none"); // Khi hien 2 anh thi k cho click vao anh thu 3        
        pos2 = clicked; // Luu lai vi tri anh 2

        if (pos1.attr("alt") == pos2.attr("alt")) {
            await sleep(300); // Ngủ 0.3 s
            // pos1: Image
            // pos2: Text
            // Using Swap on pos1 = Text when ...
            let temp = 0;
            if (pos1.attr('data-mode') == 1) {
                temp = pos1;
                pos1 = pos2;
                pos2 = temp;
            } 

            let image1 = pos1.attr('image');

            pos1.attr("src", image1);
            pos2.attr("src", '//');
            var divText = $(pos2).parent().find(".text");
            divText.removeAttr("hidden");
            //
            $(pos1).parent().addClass("square-complete");
            $(pos2).parent().addClass("square-complete");

            //Show popup
            $("#myModal").modal("show");
            $("#myModal").find(".modal-title").text(pos1.attr("data-name") + ": " + pos1.attr("data-vietnamese"));
            $("#myModal").find("img").attr("src", src);

            //Sound
            COMMON.Audio.AutoStart("sound", pos1.attr("data-sound"));
            COMMON.Audio.NoAutoStart("pronounce", pos1.attr("data-pronounce"));

            // Kiem tra da mo het tat ca cac hinh
            complete++;
            if (complete == 8) {
                $(".complete").css("opacity", "1"); // Show Congratulation 
                $(".square-complete").each(function () {
                    $thiscomplete = $(this);
                    if ($thiscomplete.find("img").attr("data-mode") == "1") {
                        $thiscomplete.css("display", "none"); // An di nhung o la chu
                    }
                    else {
                        // Cap nhat lai su kien cho cac o hinh
                        //$thiscomplete.css("cursor", "pointer");
                        //$thiscomplete.css("pointer-events", "auto");
                        $thiscomplete.removeClass("square-complete");
                        $thiscomplete.find("img").attr("onclick", "showModal($(this))");
                    }
                });
                
            }
        }
        else {
            await sleep(1000); // Ngủ 1 s

            // Hidden Text = Hidden Element
            var divText = $(pos1).parent().find(".text");
            divText.prop("hidden", true);
            divText = $(pos2).parent().find(".text");
            divText.prop("hidden", true);

            //Show Image = Show Element
            pos1.attr("src", "/images/question-mark.png");
            pos2.attr("src", "/images/question-mark.png");
            $(pos1).show();
            $(pos2).show();

            
        }
        $(".square:not(.square-complete)").css("pointer-events", "auto"); // Enable click vao anh        
        k = 0; //Reset
    };
}

var COMMON = new function () {
    this.Audio = new function () {
        this.AutoStart = function(elementID, sourceAudio){
            //Set source audio
            $("#" + elementID).find("source").attr("src", sourceAudio);

            //Config
            var audio = document.getElementById(elementID);

            audio.load(); //call this to just preload the audio without playing
            audio.play(); //call this to play the song right away
        };//end AutoStart


        this.NoAutoStart = function(elementID, sourceAudio){
            //Set source audio
            $("#" + elementID).find("source").attr("src", sourceAudio);

            //Config
            var audio = document.getElementById(elementID);

            audio.load(); //call this to just preload the audio without playing
        };//end NoAutoStart
    }

}

function showModal(e) {
    $("#myModal").modal("show");
    $("#myModal").find(".modal-title").text(e.attr("data-name") + ": " + e.attr("data-vietnamese"));
    $("#myModal").find("img").attr("src", e.attr("image"));

    COMMON.Audio.AutoStart("sound", e.attr("data-sound"));
    COMMON.Audio.NoAutoStart("pronounce", e.attr("data-pronounce"));
}