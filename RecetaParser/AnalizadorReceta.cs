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
        internal class recipes
        {
            public recipes(int id_recipes, string name, int portions, int calories, int? prep_time = 0, string? prep_time_unit = "", int? cook_time = 0, string? cook_time_unit = "")
            => (this.id_recipes, this.name, this.portions, this.prep_time_unit,this.prep_time_unit,this.cook_time,this.cook_time_unit,this.calories) = (id_recipes, name, portions, prep_time_unit,prep_time_unit,cook_time, cook_time_unit, calories);

            public int id_recipes;
            public string name = "";
            public int portions;
            public int? prep_time;//nulls
            public string? prep_time_unit;//nulls
            public int? cook_time;//nulls
            public string? cook_time_unit;//nulls
            public int calories;

            public string ObtenerInsert()
            {
                return ($"INSERT INTO recipes (id, name, portions, prep_time, prep_time_unit, cook_time, cook_time_unit, calories)"+
                        $"VALUES({id_recipes}, {name}, {portions}, {prep_time}, {prep_time_unit}, {cook_time}, {cook_time_unit}, {calories}); ");
            }
        }

        internal class ingredients
        {
            //INSERT INTO ingredients(id, recipe_id, name, quantity, unit_id) VALUES(1, 1, 'leche evaporada', 2.5, 3);
            public int id_ingredientes;
            public int recipe_id;
            public string name = "";
            public decimal quantity;
            public int? unit_id;
        }

        internal class cooking_steps
        {
            public int id_CS;
            public int step_number;
            public string description = "";
        }

        internal class ingredient_units
        {
            public int id;
            public string text = "";
        }
        public override string VisitCalorias([NotNull] ProyectoRecetarioParser.CaloriasContext context)
        {
            return base.VisitCalorias(context);
        }

        public override string VisitDet_elaboracion([NotNull] ProyectoRecetarioParser.Det_elaboracionContext context)
        {
            return base.VisitDet_elaboracion(context);
        }

        public override string VisitDet_ingredientes([NotNull] ProyectoRecetarioParser.Det_ingredientesContext context)
        {
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

        public override string VisitNombre([NotNull] ProyectoRecetarioParser.NombreContext context)
        {
            return base.VisitNombre(context);
        }

        public override string VisitPorciones([NotNull] ProyectoRecetarioParser.PorcionesContext context)
        {
            return base.VisitPorciones(context);
        }

        public override string VisitProgram([NotNull] ProyectoRecetarioParser.ProgramContext context)
        {
            return base.VisitProgram(context);
        }

        public override string VisitReceta([NotNull] ProyectoRecetarioParser.RecetaContext context)
        {
            return base.VisitReceta(context);
        }

        public override string VisitTiempoCoccion([NotNull] ProyectoRecetarioParser.TiempoCoccionContext context)
        {
            return base.VisitTiempoCoccion(context);
        }

        public override string VisitTiempoPreparacion([NotNull] ProyectoRecetarioParser.TiempoPreparacionContext context)
        {
            return base.VisitTiempoPreparacion(context);
        }
    }
}
