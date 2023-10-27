namespace alici
{
    public  class GlobalVariables
    {
     //esta clase se encarga de guardar unicamente el tipo de usuario autenticado 
        private static string v_Variable = string.Empty;
        public static string VariableOne
        {
            get
            {
                return v_Variable;
            }
            set
            {
                v_Variable = value;
            }
        }
    }
}