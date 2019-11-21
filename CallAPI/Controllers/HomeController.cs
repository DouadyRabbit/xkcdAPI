using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using APILibrary;
using System.Threading.Tasks;

namespace CallAPI.Controllers
{
    public class HomeController : Controller
    {
        private static int maxNumber = 0;
        private static int currentNumber = 0;

        public async Task<ViewResult>  Index()
        {
            
            APIHelper.InitializeClient();
            int id = 0;
            
            ComicModel comic = await ComicProcessor.LoadComic(id);
            currentNumber = comic.Num;
            maxNumber = currentNumber;

            ViewBag.Id = currentNumber;

            comic.btnNextDisabled = true;
            comic.btnPrevDisabled = false;
            return View(comic);
        }

        [HttpGet]
        public async Task<ViewResult> LoadImage(int id = 0)
        {

            if(id > maxNumber)
            {
                currentNumber = 0;
            
            }
            else
            {
                currentNumber = id;
            }

            ComicModel comic = await ComicProcessor.LoadComic(currentNumber);


            switch (currentNumber)
            {
                case 0:
                    comic.btnNextDisabled = true;
                    comic.btnPrevDisabled = false;
                    break;

                case 1:
                    comic.btnNextDisabled = false;
                    comic.btnPrevDisabled = true;
                    break;

                default:
                   comic.btnNextDisabled = false;
                   comic.btnPrevDisabled = false;
                    break;
            }

              ViewBag.Id = currentNumber;

            return View(comic);
        }
    }
}