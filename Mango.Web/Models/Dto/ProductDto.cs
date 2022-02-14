using System.ComponentModel;

namespace Mango.Web.Models.Dto
{
    public class ProductDto
    {
        public int ProductId { get; set; }
        [DisplayName("Наименование")]
        public string Name { get; set; }
        [DisplayName("Цена")]
        public double Price { get; set; }
        [DisplayName("Описание")]
        public string Description { get; set; }
        [DisplayName("Категория")]
        public string CategoryName { get; set; }
        [DisplayName("Url изображения")]
        public string ImageUrl { get; set; }
    }
}
