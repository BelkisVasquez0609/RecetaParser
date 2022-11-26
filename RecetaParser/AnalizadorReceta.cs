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
            public int id_recipes;
            public string name = "";
            public int portions;
            public int? prep_time;//nulls
            public string? prep_time_unit;//nulls
            public int? cook_time;//nulls
            public string? cook_time_unit;//nulls
            public int calories;
        }

        public class ingredients
        {
            public int id_ingredientes;
            public int recipe_id;
            public string name = "";
            public decimal quantity;
            public int? unit_id;
        }

        public class cooking_steps
        {
            public int id_CS;
            public int step_number;
            public string description = "";
        }

        public class ingredient_units
        {
            public int id;
            public string text = "";
        }

        public override string VisitDet_elaboracion([NotNull] ProyectoRecetarioParser.Det_elaboracionContext context)
        {
            cooking_steps step = new cooking_steps();
            step.step_number = Convert.ToInt32(context.NUM().GetText());
            step.description = context.TEXT().GetText();
            return base.VisitDet_elaboracion(context);
        }

        public override string VisitDet_ingredientes([NotNull] ProyectoRecetarioParser.Det_ingredientesContext context)
        {
            ingredients ingr = new ingredients();
            ingr.name = context.TEXT().GetText();
            ingr.quantity = Convert.ToInt32(context.NUM().GetText());

            return base.VisitDet_ingredientes(context);
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
            recipes receta = new recipes();
            receta.name = context.nombre().GetText();
            receta.portions = Convert.ToInt32(context.porciones().GetText());
            receta.prep_time = Convert.ToInt32(context.tiempoPreparacion().NUM().GetText());
            receta.prep_time_unit = context.tiempoPreparacion().TEXT().GetText();
            receta.cook_time = Convert.ToInt32(context.tiempoCoccion().NUM().GetText());
            receta.cook_time_unit = context.tiempoCoccion().TEXT().GetText();
            receta.calories = Convert.ToInt32(context.calorias().GetText());
            return base.VisitReceta(context);
        }
    }
}
