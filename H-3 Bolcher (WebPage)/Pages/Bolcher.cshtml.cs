using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using H_3_Bolcher__WebPage_.Models;
using H_3_Bolcher__WebPage_.Database;
using Microsoft.IdentityModel.Tokens;

namespace H_3_Bolcher__WebPage_.Pages
{
    public class BolcherModel : PageModel
    {

        string SearchText = string.Empty;

        public List<Bolcher> bolchers = new List<Bolcher>();
        public Bolcher bolcher = new Bolcher();
        Db db = new Db();
        public void OnGet()
        {


            //bolchers = db.GetAllBolcher();

        }
        public void OnPostVisalle()
        {
            bolchers = db.GetAllBolcher();
        }
        public void OnPostSearch()
        {
            string SearchBox = Request.Form["SearchBox"].ToString();
            SearchBox = SearchBox.Trim();
            string CheckBoxFromBegining = Request.Form["CheckFromBegining"].ToString();
            if (!SearchBox.IsNullOrEmpty())
            {


                if (CheckBoxFromBegining == "on")
                {
                    bolchers = db.GetAllBolcherWhereSearchWordIsFromBegining(SearchBox);
                }
                else
                {
                    bolchers = db.GetAllBolcherWhereSearchWordIs(SearchBox);

                }
            }
            else
            {

            }
        }
    }
}
