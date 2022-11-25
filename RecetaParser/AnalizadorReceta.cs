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
