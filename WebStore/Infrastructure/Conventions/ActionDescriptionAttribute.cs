using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace WebStore.Infrastructure.Conventions
{
    public class ActionDescriptionAttribute : Attribute, IActionModelConvention
    {
        private readonly string _Description;
        
        public ActionDescriptionAttribute(string Description) => _Description = Description;

        public void Apply(ActionModel action)
        {
            action.Properties["description"] = _Description;
        }
    }
}
