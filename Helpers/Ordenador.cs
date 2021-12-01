using System.Linq;
using System.Reflection;
using System.Text;
using System;
using System.Linq.Dynamic.Core;

namespace DonPepe.Helpers
{
    public class Ordenador<T>
    {
        //Pendiente aplicar
        public static IQueryable<T> Ordenar(IQueryable entidades,string CampoOrdenamiento){

            var parametros= CampoOrdenamiento.Trim().Split(',');
            var infopropiedades= typeof(T).GetProperties(BindingFlags.Public |BindingFlags.Instance);
            var BuilderOrden= new StringBuilder();

            foreach( var par in parametros){

                var propQuery=par.Split(" ")[0];
                var objprop= infopropiedades.FirstOrDefault(x=>x.Name.Equals(propQuery));

                BuilderOrden.Append($"{objprop.Name} ,");
            }

            var consultaOrden=BuilderOrden.ToString().TrimEnd(',',' ');
            return (IQueryable<T>)entidades.OrderBy(consultaOrden);

        }

    }
}