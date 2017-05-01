using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2
{
    public class Regulars
    {
        [RegularExpression("[0-9]{0,5}", ErrorMessage = "Поле 'Id (идентификатор)' имеет неверный формат! Допустимы только цифры")]
        public float Id { get; set; }
        [Required(ErrorMessage = "Обязательное поле")]
        [RegularExpression("[a-zA-Zа-яА-Я]{1,20}", ErrorMessage = "Поле 'Name (Название товара)' имеет неверный формат! Допустимы только буквы")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        [RegularExpression("[0-9]{0,15}", ErrorMessage = "Поле 'Count (количество товара)' имеет неверный формат! Допустимы только цифры")]
        public float Count { get; set; }

        [RegularExpression("[0-9]{0,15}", ErrorMessage = "Поле 'Price (цена товара)' имеет неверный формат! Допустимы только цифры")]
        public float Price { get; set; }
    }
}
