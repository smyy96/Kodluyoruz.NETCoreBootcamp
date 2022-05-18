using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BionlukAPI.Filters
{
    public class IsExistAttribute : TypeFilterAttribute
    {
        public IsExistAttribute(): base(typeof(IsExistsOperation))
        {

        }
    }
}
