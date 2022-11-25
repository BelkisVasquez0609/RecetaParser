using Antlr4.Runtime.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetaParser
{
    internal class AnalizadorReceta : ProyectoRecetarioBaseVisitor<string>
    {
		public class recipes
		{
			int id_recipes;
			string name = "";
			int portions;
			int? prep_time;//nulls
			string? prep_time_unit;//nulls
			int? cook_time;//nulls
			string? cook_time_unit;//nulls
			int calories;

		}

		public class ingredients
		{
			int id_ingredientes;
			int recipe_id;
			string name = "";
			decimal quantity;
			int? unit_id;
		}

		public class cooking_steps
		{
			int id_CS;
			int step_number;
			string description = "";
		}

		public class ingredient_units
		{
			int id;
			string text = "";
		}
		public override string VisitInformacion([NotNull] ProyectoRecetarioParser.InformacionContext context)
        {
            return base.VisitInformacion(context);
        }

        public override string VisitElaboracion([NotNull] ProyectoRecetarioParser.ElaboracionContext context)
        {
            return base.VisitElaboracion(context);
        }

        public override string VisitIngredientes([NotNull] ProyectoRecetarioParser.IngredientesContext context)
        {
            return base.VisitIngredientes(context);
        }

        public override string VisitProgram([NotNull] ProyectoRecetarioParser.ProgramContext context)
        {
            return base.VisitProgram(context);
        }

        public override string VisitReceta([NotNull] ProyectoRecetarioParser.RecetaContext context)
        {
            
            return base.VisitReceta(context);
        }
    }
}
