using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using H_3_Bolcher__WebPage_.Models;
using H_3_Bolcher__WebPage_.Database;
using Microsoft.IdentityModel.Tokens;

namespace H_3_Bolcher__WebPage_.Pages
{
    public class BolcherModel : PageModel
    {
        public string NumberCount = string.Empty;
        string SearchText = string.Empty;
        public string Message = string.Empty;
        public List<Bolcher> bolchers = new List<Bolcher>();
        public List<Bolcher> bolchers2 = new List<Bolcher>();
        public List<Bolche_Omkostninger> bolche_omkostninger = new List<Bolche_Omkostninger>();
        public List<Kunde_ordrer> kundeordrer = new List<Kunde_ordrer>();
        public Bolcher bolcher = new Bolcher();
        Db db = new Db();
        public void OnGet()
        {
            bolchers2 = db.GetAllBolcher();
        }

        public void OnPostVisalle()
        {
            //SQL-03 (1)
            bolchers = db.GetAllBolcher();
        }
        public void OnPostSearch()
        {
            NumberCount = "1";
            string SearchBox = Request.Form["SearchBox"].ToString();
            string FaveSelect = Request.Form["FaveSelect"].ToString();
            SearchBox = SearchBox.Trim();
            string CheckBoxFromBegining = Request.Form["CheckFromBegining"].ToString();
            if (!SearchBox.IsNullOrEmpty() || !FaveSelect.IsNullOrEmpty())
            {
                //SQL-03 (4)
                if (!FaveSelect.IsNullOrEmpty())
                {
                    if (SearchBox.IsNullOrEmpty())
                    {
                        bolchers = db.GetAllBolcherWithColor(FaveSelect);
                    }
                    else
                    {
                        if (CheckBoxFromBegining == "on")
                        {
                            bolchers = db.GetAllBolcherWhereSearchWordIsFromBeginingWithColor(SearchBox, FaveSelect);
                        }
                        else
                        {
                            bolchers = db.GetAllBolcherWhereSearchWordIsWithColor(SearchBox, FaveSelect);
                        }
                    }
                }
                else
                {
                    if (!SearchBox.IsNullOrEmpty())
                    {
                        if (CheckBoxFromBegining == "on")
                        {
                            //SQL-03 (2)
                            bolchers = db.GetAllBolcherWhereSearchWordIsFromBegining(SearchBox);
                        }
                        else
                        {
                            //SQL-03 (3)
                            bolchers = db.GetAllBolcherWhereSearchWordIs(SearchBox);

                        }
                    }
                }
            }
            else
            {
                Message = "Vælg søgekriterier eller klik på Vis alle";
                NumberCount = "0";
            }
        }
        public void OnPostBtnSalgspris_pr_100_gram()
        {
            bolche_omkostninger = db.GetAllBolcherWithNettoprisAndSalgspris();
        }
        public void OnPostAllKunder()
        {
            //GetAllFromKundeWithOrdres
            bolchers2 = db.GetAllBolcher();
            string bolchenavne = Request.Form["bolchenavne"].ToString();
            if (!bolchenavne.IsNullOrEmpty())
            {
                kundeordrer = db.GetAllFromKundeWithOrdres(bolchenavne);
            }

        }
    }
}
