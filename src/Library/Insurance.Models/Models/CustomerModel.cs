using FluentValidation;
using System;

namespace Insurance.Models.Models
{
    public class CustomerModel
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public string SURNAME { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string NATIONALITY { get; set; }
        public string IDENTIFICATIONNUMBER { get; set; }
        public string BIRTHDATE { get; set; }
        public string GENDER { get; set; }
        public string EMAIL { get; set; }
        public string PHONE { get; set; }
        public string ADRESS { get; set; }
        public string CREATEDATE { get; set; }
        public string UPDATEDATE { get; set; }
        public decimal CREATEBY { get; set; }
        public decimal UPDATEBY { get; set; }
    }

    public class CustomerValidator : AbstractValidator<CustomerModel>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.BIRTHDATE).NotEmpty().WithMessage("Required Field");
        }
        public bool ValidDate(DateTime date)
        {
            var current = DateTime.Now.Year;
            var sonuc = current - Convert.ToInt32(date);
            if (sonuc >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
