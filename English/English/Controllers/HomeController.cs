using English.Models;
using English.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace English.Controllers
{
    public class HomeController : Controller
    {
        EnglishContext englishContext = new EnglishContext();
        public ActionResult Index()
        {
            List<Animals> animals = new List<Animals>();
            // Get random 8 animals in database
            animals = englishContext.Animals
                .OrderBy(r => Guid.NewGuid()).Take(8).ToList();

            List<AnimalsViewModel> animalViewModels = new List<AnimalsViewModel>();

            foreach (var a in animals)
            {
                AnimalsViewModel imageViewModel = new AnimalsViewModel()
                {
                    Id = a.Id,
                    Name = a.Name,
                    Vietnamese = a.Vietnamese,
                    ImageUrl = a.ImageUrl,
                    PronounceUrl = a.PronounceUrl,
                    SoundUrl = a.SoundUrl,
                    Mode = 0,
                };

                // Get duplicate of 8 animals
                Animals animal = englishContext.Animals.FirstOrDefault(p => p.Id == a.Id);
                AnimalsViewModel vocabularyViewModel = new AnimalsViewModel()
                {
                    Id = animal.Id,
                    Name = animal.Name,
                    Vietnamese = animal.Vietnamese,
                    ImageUrl = animal.ImageUrl,
                    PronounceUrl = animal.PronounceUrl,
                    SoundUrl = animal.SoundUrl,
                    Mode = 1,
                };

                // Add to list
                animalViewModels.Add(imageViewModel);
                animalViewModels.Add(vocabularyViewModel);

            }

            // Mix animals in list
            Random random = new Random();
            for (int i = 0; i < animalViewModels.Count; i++)
            {
                AnimalsViewModel temp = animalViewModels[i];
                int randomIndex = random.Next(i, animalViewModels.Count);
                animalViewModels[i] = animalViewModels[randomIndex];
                animalViewModels[randomIndex] = temp;
            }

            return View(animalViewModels);
        }

        public ActionResult Number()
        {
            List<Number> animals = new List<Number>();
            // Get random 8 animals in database
            animals = englishContext.Number
                .OrderBy(r => Guid.NewGuid()).Take(25).ToList();

            List<NumbersViewModel> numbersViewModels = new List<NumbersViewModel>();

            foreach (var a in animals)
            {
                NumbersViewModel imageViewModel = new NumbersViewModel()
                {
                    Id = a.Id,
                    ImageUrl = a.ImageUrl,
                    PronounceUrl = a.PronounceUrl,
                    SoundUrl = a.SoundUrl,
                    Mode = 0,
                };

                // Add to list
                numbersViewModels.Add(imageViewModel);

            }

            // Mix animals in list
            Random random = new Random();
            for (int i = 0; i < numbersViewModels.Count; i++)
            {
                NumbersViewModel temp = numbersViewModels[i];
                int randomIndex = random.Next(i, numbersViewModels.Count);
                numbersViewModels[i] = numbersViewModels[randomIndex];
                numbersViewModels[randomIndex] = temp;
            }

            return View(numbersViewModels);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}