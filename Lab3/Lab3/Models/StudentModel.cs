using System.Collections.Generic;
using System.Data.Entity;
using System.Web.Mvc;

namespace Lab3.Models
{
    public enum SexType
    {
        Male = 0,
        Female = 1,
        Other = 2
    }
    public class StudentModel
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public double Bani { get; set; }
        public int Varsta { get; set; }
        public SexType? Sex { get; set; }
        public uint Restante { get; set; }
    }

    public static class HtmlHelpers
    {
        public static List<SelectListItem> ToList()
        {
            List<SelectListItem> values = new List<SelectListItem>();

            foreach (var enumValue in typeof(SexType).GetEnumValues())
            {
                var sli = new SelectListItem
                {
                    Value = ((int) enumValue).ToString(),
                    Text = enumValue.ToString()
                };
                values.Add(sli);
            }

            return values;
        } 
    }

    public class SutdentContext : DbContext
    {
        public SutdentContext() : base("StudentConnectionWithRestante")
        {
            
        }

        public DbSet<StudentModel> Students { get; set; }

    }
}