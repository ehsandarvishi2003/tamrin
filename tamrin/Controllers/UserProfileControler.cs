using Microsoft.AspNetCore.Mvc;
using tamrin.DTOs;

namespace tamrin.Controllers
{
    public class UserProfileControler : Controller
    {
        public IActionResult ShowUserProfile()
        {
            List<UserProfileDTO> pageModel = new List<UserProfileDTO>();

            #region Object Maping 1

            UserProfileDTO ehsanDarvishi = new UserProfileDTO()
            {
                Age = 21,
                Birthday = "2003/12/4",
                EducationLevel = "Diploma",
                UserAvatar = "01.JPG",
                UserStory = "02.JPG",
                UserName = "Ehsan Darvishi ",
            };

            pageModel.Add(ehsanDarvishi);

            #endregion

            #region Object Maping 2

            UserProfileDTO AliAkbary = new UserProfileDTO()
            {
                Age = 20,
                Birthday = "2004/12/4",
                EducationLevel = "Diploma",
                UserAvatar = "03.JPG",
                UserStory = "04.JPG",
                UserName = "Ali Akbary"
            };
            pageModel.Add(AliAkbary);

            #endregion

            return View(pageModel);
        }
    }
}
