using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace English.ViewModels
{
    public class AnimalsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Vietnamese { get; set; }
        public string ImageUrl { get; set; }
        public string PronounceUrl { get; set; }
        public string SoundUrl { get; set; }
        /// <summary>
        /// 0= Show Hình ảnh || 1 = Show Từ vựng
        /// </summary>
        public int Mode { get; set; }
    }
}
