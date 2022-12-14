using Antlr4.Runtime.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace RecetaParser
{
    internal class recipes
    {
        public recipes(int id_recipes, string name, int portions, int calories, string? prep_time = "", string? prep_time_unit = "", string? cook_time = "", string? cook_time_unit = "")
        => (this.id_recipes, this.name, this.portions, this.calories, this.prep_time, this.prep_time_unit, this.cook_time, this.cook_time_unit) = (id_recipes, name, portions, calories, prep_time, prep_time_unit, cook_time, cook_time_unit);

        public int id_recipes;
        public string name = "";
        public int portions;
        public string? prep_time;//nulls
        public string? prep_time_unit;//nulls
        public string? cook_time;//nulls
        public string? cook_time_unit;//nulls
        public int calories;

        public string ObtenerInsert()
        {
            return ($"/*-------------------------------RECIPE: {name} ---------------------------------------------*/\n" +
                    $"\nINSERT INTO recipes (id, name, portions, {(prep_time is not null ? "prep_time," : "")} {(prep_time_unit is not null ? "prep_time_unit," : "")} {(cook_time is not null ? "cook_time," : "")} {(cook_time_unit is not null ? "cook_time_unit," : "")} calories)" +
                    $"VALUES({id_recipes}, '{name}', {portions}, {(prep_time is not null ? $"{prep_time}," : "")} {(prep_time is not null ? $"'{prep_time_unit}'," : "")} {(prep_time is not null ? $"{cook_time}," : "")}  {(prep_time is not null ? $"'{cook_time_unit}'," : "")}{calories}); \n"+
					$"\n/*********************************** INGREDIENTS *********************************************/\n");
        }
    }
    internal class ingredients
    {
        public ingredients(int id_ingredientes, string name, decimal quantity, int? unit_id=0)
            => (this.id_ingredientes, this.name, this.quantity, this.unit_id) = (id_ingredientes, name, quantity, unit_id);

        public int id_ingredientes;
        public int recipe_id;
        public string name = "";
        public decimal quantity;
        public int? unit_id;

        public string ObtenerInsert()
        {
            return ( 
				$"INSERT INTO ingredients(id, recipe_id, name, quantity, unit_id)" +
                $"VALUES({id_ingredientes}, {recipe_id}, '{name}', {quantity}, {unit_id});\n");
        }
    }
    internal class cooking_steps
    {
        public cooking_steps(int id_CS, int step_number, string description)
            => (this.id_CS, this.step_number, this.description) = (id_CS, step_number, description);

        public int id_CS;
        public int step_number;
        public string description = "";
        public int recipe_id;

        public string ObtenerInsert()
        {
     
            if (step_number == 1)
            {
				return ($"/*================================== Cooking Steps =======================================*/\n" +
					$"\nINSERT INTO cooking_steps (id, step_number, description, recipe_id) VALUES ({id_CS}, {step_number}, '{description}', {recipe_id});\n");
			}
            else
            {
				return ($"INSERT INTO cooking_steps (id, step_number, description, recipe_id) VALUES ({id_CS}, {step_number}, '{description}', {recipe_id});\n");
			}

        }
    }

    internal class AnalizadorReceta : ProyectoRecetarioBaseVisitor<object>
    {
        private int ingCount = 0;
		private int stepCount = 0;
        private int recipeCount = 0;
        List<string> outPut = new List<string>();
        public List<string> OutPut
        {
            get => outPut;
        }

		public override object VisitNombre([NotNull] ProyectoRecetarioParser.NombreContext context)
        {   
            return context.TEXT().GetText();
        }

        public override object VisitPorciones([NotNull] ProyectoRecetarioParser.PorcionesContext context)
        {   
            return Convert.ToInt32(context.NUM().GetText());
        }
        public override object VisitProgram([NotNull] ProyectoRecetarioParser.ProgramContext context)
        {
			string insertResult = "";
			try
			{
				base.VisitProgram(context);
         
                foreach (var i in outPut)
                insertResult += i + "\n";
			}
			catch (Exception ex)
			{

				Console.WriteLine("Method VisitProgram exception - " + ex.Message);
			}

			return insertResult;
		}

        public override object VisitReceta([NotNull] ProyectoRecetarioParser.RecetaContext context)
        {
            try
            {

           
            recipeCount++;
            string name = (string)Visit(context.nombre());
            int portions = (int)Visit(context.porciones());
            int calorias = Convert.ToInt32(Visit(context.calorias()));
				string? prep_time;
            string? prep_time_unit;
				string? cook_time;
            string? cook_time_unit;
		
				prep_time = (string?)context.tiempoPreparacion()?.NUM().GetText();
				prep_time_unit = (string?)context.tiempoPreparacion()?.TEXT().GetText();

				cook_time = (string?)context.tiempoCoccion()?.NUM().GetText();
				cook_time_unit = (string?)context.tiempoCoccion()?.TEXT().GetText();


            recipes receta = new recipes(recipeCount, name, portions, calorias, prep_time, prep_time_unit, cook_time, cook_time_unit);
            List<ingredients> ingredients = (List<ingredients>)Visit(context.ingredientes());
            List<cooking_steps> cooking_steps = (List<cooking_steps>)Visit(context.elaboracion());


            outPut.Add(receta.ObtenerInsert());

            foreach (var ingredient in ingredients)
            {
                ingredient.recipe_id = receta.id_recipes;
                outPut.Add(ingredient.ObtenerInsert());

            }
            foreach (var step in cooking_steps)
            {
                step.recipe_id = receta.id_recipes;
                outPut.Add(step.ObtenerInsert());
            }
            
			}
			catch (Exception ex)
			{

				Console.WriteLine("Method VisitReceta exception - "+ ex.Message);
			}
			return new Object();
		}
        public override object VisitCalorias([NotNull] ProyectoRecetarioParser.CaloriasContext context)
        {
            int? Calories;
            try
            {
                Calories = Convert.ToInt32(context.NUM().GetText());

			}
            catch (Exception ex)
            {
                Calories = 0;
				Console.WriteLine("Method VisitCalorias exception - " + ex.Message);
			}
            return Calories;
        }
        public override object VisitDet_elaboracion([NotNull] ProyectoRecetarioParser.Det_elaboracionContext context)
        {
            stepCount++;
            cooking_steps cookingSteps;

			try
            {
				int stepNumber = Convert.ToInt32(context.NUM().GetText());
				string stepDescription = context.TEXT().GetText();
				cookingSteps = new cooking_steps(stepCount, stepNumber, stepDescription);
			}
			catch (Exception ex)
			{
                cookingSteps = null;
				Console.WriteLine("Method VisitDet_elaboracion exception - " + ex.Message);
			}

			return cookingSteps;
		}
		public override object VisitDet_ingredientes([NotNull] ProyectoRecetarioParser.Det_ingredientesContext context)
        {
            decimal quantity = decimal.Parse(context.NUM().GetText());
            string name = context.TEXT().GetText();
            int unit_id = 0;
            if (name.Contains("cucharadita"))
            {
                unit_id = 1;
            }
            else if (name.Contains("cucharada"))
            {
                unit_id = 2;
            }
            else if(name.Contains("taza"))
            {
                unit_id = 3;
            }
            ingCount++;
            ingredients ing = new ingredients(ingCount, name, quantity, unit_id);

            return ing;
        }

        public override object VisitElaboracion([NotNull] ProyectoRecetarioParser.ElaboracionContext context)
        {
			List<cooking_steps> cookingStep = new List<cooking_steps>();
			foreach (var cookingStepTree in context.det_elaboracion())
			{
				cookingStep.Add((cooking_steps)Visit(cookingStepTree));
			}
			return cookingStep;
		}

        public override object VisitIngredientes([NotNull] ProyectoRecetarioParser.IngredientesContext context)
        {
			List<ingredients> ingredientes = new List<ingredients>();
			foreach (var ingrediente_tree in context.det_ingredientes())
			{
				ingredientes.Add((ingredients)Visit(ingrediente_tree));
			}
			return ingredientes;
		}

    }
}
