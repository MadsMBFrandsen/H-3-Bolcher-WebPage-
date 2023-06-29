namespace H_3_Bolcher__WebPage_.Models
{
    public class Bolche_Omkostninger
    {
        public int Id { get; set; }
        public string Navn { get; set; }
        public int Vægt_i_gram { get; set; }
        public int Råvarepris_i_øre { get; set; }
        public Decimal Nettopris { get; set; }
        public Decimal Salgspris { get; set; }
        public Decimal Salgspris_pr_100_gram { get; set; }

    }
}
