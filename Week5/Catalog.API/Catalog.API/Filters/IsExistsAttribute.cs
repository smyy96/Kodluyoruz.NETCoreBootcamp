using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Catalog.API.Filters
{
    public class IsExistsAttribute : TypeFilterAttribute
    {
        public IsExistsAttribute() : base(typeof(IsExistOperation)) //Attribute lerde dependency injection kullanamadıgımız için işleri IsExistOperation yaptırdık
        {

        }
    }
}
