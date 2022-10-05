namespace WEB1001_Fall2022_Layouts.Models
{
    public class Product
    {
        private string? m_UPC;

        public string? UPC {
            get
            {
                return m_UPC;
            }
            set
            {
                m_UPC = value;
            }
        }
        public string? Name { get; set; }
        public string? Image { get; set; }
    }
}
