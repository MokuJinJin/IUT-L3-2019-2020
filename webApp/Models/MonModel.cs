using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webApp.Models
{
    public class MonModel
    {
        [Obsolete("ne pas putiliser", true)]
        public string Informations { get; set; }

        public List<string> InfoAffichable;

        private string caché { get; set; }

        protected string famille;
    }
    public interface IModel
    {
        int MyProperty { get; set; }
        void Method();
    }
    public class ModelAutre : IModel
    {
        public int MyProperty { get; set; }

        public void Method()
        {
            throw new NotImplementedException();
        }
    }

    public class ModelEnfant : IModel
    {
        public int MyProperty { get; set ; }

        public void Method()
        {
            try
            {

            }
            catch(NullReferenceException e)
            {

            }
            catch (Exception e)
            {

            }
            List<IModel> list = new List<IModel>();
            list.Add(new ModelEnfant());
            list.Add(new ModelAutre());
            list.Comptage();
        }
    }
    
}
