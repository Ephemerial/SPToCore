﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace SPToCore.T4
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class SPToCoreT4 : SPToCoreT4Base
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("using System;\r\nusing System.Data;\r\nusing System.Collections.Generic;\r\nusing Micro" +
                    "soft.Data.SqlClient;\r\nusing System.Threading.Tasks;\r\nusing Microsoft.EntityFrame" +
                    "workCore;\r\n\r\nnamespace ");
            
            #line 13 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    public partial class ");
            
            #line 15 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SourceDbContext));
            
            #line default
            #line hidden
            this.Write(" : DbContext\r\n    {\r\n");
            
            #line 17 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
 foreach (var sp in SpList){ if (sp.Results.Count > 0) {
            
            #line default
            #line hidden
            this.Write("        private DbSet<");
            
            #line 18 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(sp.Name));
            
            #line default
            #line hidden
            this.Write("Result> ");
            
            #line 18 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(sp.Name));
            
            #line default
            #line hidden
            this.Write(" { get; set; }\r\n");
            
            #line 19 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
 }}
            
            #line default
            #line hidden
            this.Write("       \r\n        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)\r\n" +
                    "        {            \r\n            // No key            \r\n");
            
            #line 24 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
    foreach (var sp in SpList){ if (sp.Results.Count > 0){
            
            #line default
            #line hidden
            this.Write("            modelBuilder.Entity<");
            
            #line 25 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(sp.Name));
            
            #line default
            #line hidden
            this.Write("Result>().HasNoKey();\r\n");
            
            #line 26 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
    }}
            
            #line default
            #line hidden
            this.Write("        }\r\n\r\n");
            
            #line 29 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
 foreach (var sp in SpList){ 
            
            #line default
            #line hidden
            this.Write("        ");
            
            #line 30 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(sp.GetMethodDefinitionAsync()));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 30 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
 foreach (var p in sp.Params){ 
            
            #line default
            #line hidden
            
            #line 30 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture((p.Order == "1" ? "" : "," )));
            
            #line default
            #line hidden
            
            #line 30 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture((p.isOutput ? "ref " : "" )));
            
            #line default
            #line hidden
            
            #line 30 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Type));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 30 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Param));
            
            #line default
            #line hidden
            
            #line 30 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
}
            
            #line default
            #line hidden
            this.Write(")\r\n        {\r\n");
            
            #line 32 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
if (sp.Results.Count > 0){
            
            #line default
            #line hidden
            this.Write("            //Initialize Result \r\n            List<");
            
            #line 34 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(sp.Name));
            
            #line default
            #line hidden
            this.Write("Result> lst = new List<");
            
            #line 34 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(sp.Name));
            
            #line default
            #line hidden
            this.Write("Result>();\r\n");
            
            #line 35 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
}
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 37 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
if (sp.Params.Count > 0) {
            
            #line default
            #line hidden
            this.Write("                // Parameters\r\n");
            
            #line 39 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
 foreach (var p in sp.Params){ 
            
            #line default
            #line hidden
            this.Write("                SqlParameter p_");
            
            #line 40 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Param));
            
            #line default
            #line hidden
            this.Write(" = new SqlParameter(\"@");
            
            #line 40 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Param));
            
            #line default
            #line hidden
            this.Write("\", ");
            
            #line 40 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Param));
            
            #line default
            #line hidden
            this.Write(" ?? (object)DBNull.Value);\r\n                p_");
            
            #line 41 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Param));
            
            #line default
            #line hidden
            this.Write(".Direction = ParameterDirection.");
            
            #line 41 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture((p.isOutput ? "Output" : "Input")));
            
            #line default
            #line hidden
            this.Write(";\r\n                p_");
            
            #line 42 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Param));
            
            #line default
            #line hidden
            this.Write(".DbType = DbType.");
            
            #line 42 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.DbType));
            
            #line default
            #line hidden
            this.Write(";\r\n                p_");
            
            #line 43 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Param));
            
            #line default
            #line hidden
            this.Write(".Size = ");
            
            #line 43 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Length));
            
            #line default
            #line hidden
            this.Write(";\r\n\r\n");
            
            #line 45 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
 }
            
            #line default
            #line hidden
            
            #line 45 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
}
            
            #line default
            #line hidden
            this.Write("\r\n                // Processing \r\n                string sqlQuery = $@\"EXEC [");
            
            #line 48 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(sp.Schema));
            
            #line default
            #line hidden
            this.Write("].[");
            
            #line 48 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(sp.Name));
            
            #line default
            #line hidden
            this.Write("] ");
            
            #line 48 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
 foreach (var p in sp.Params){ 
            
            #line default
            #line hidden
            
            #line 48 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture((p.Order == "1" ? "" : ", " )));
            
            #line default
            #line hidden
            this.Write("@");
            
            #line 48 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Param));
            
            #line default
            #line hidden
            
            #line 48 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture((p.isOutput ? " OUTPUT" : "" )));
            
            #line default
            #line hidden
            
            #line 48 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
}
            
            #line default
            #line hidden
            this.Write("\";\r\n");
            
            #line 49 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
if (sp.Results.Count > 0) {
            
            #line default
            #line hidden
            this.Write("                \r\n                //Output Data\r\n                lst = await this" +
                    ".");
            
            #line 52 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(sp.Name));
            
            #line default
            #line hidden
            this.Write(".FromSqlRaw(sqlQuery ");
            
            #line 52 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
 foreach (var p in sp.Params){ 
            
            #line default
            #line hidden
            this.Write(", p_");
            
            #line 52 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Param));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 52 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
}
            
            #line default
            #line hidden
            this.Write(").ToListAsync();");
            
            #line 52 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
}
            
            #line default
            #line hidden
            
            #line 53 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
        else{
            
            #line default
            #line hidden
            this.Write("                //Execution\r\n                this.Database.ExecuteSqlRaw(sqlQuery" +
                    " ");
            
            #line 55 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
 foreach (var p in sp.Params){ 
            
            #line default
            #line hidden
            this.Write(", p_");
            
            #line 55 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Param));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 55 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
}
            
            #line default
            #line hidden
            this.Write(");");
            
            #line 55 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
}
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 57 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
if (sp.Params.Where(x=> x.isOutput).Count() > 0) {
            
            #line default
            #line hidden
            this.Write("                \r\n                //Output Params\r\n");
            
            #line 60 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
 foreach (var p in sp.Params.Where(x=> x.isOutput)){ 
            
            #line default
            #line hidden
            this.Write("                ");
            
            #line 60 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Param));
            
            #line default
            #line hidden
            this.Write(" = (");
            
            #line 60 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Type));
            
            #line default
            #line hidden
            this.Write(")p_");
            
            #line 60 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Param));
            
            #line default
            #line hidden
            this.Write(".Value;\r\n");
            
            #line 61 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
}
            
            #line default
            #line hidden
            
            #line 62 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
}
            
            #line default
            #line hidden
            this.Write("\r\n            //Return\r\n");
            
            #line 65 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
if (sp.Results.Count > 0) {
            
            #line default
            #line hidden
            this.Write("            return lst;\r\n");
            
            #line 67 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
}
            
            #line default
            #line hidden
            this.Write("        }\r\n\r\n");
            
            #line 70 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
if (sp.Results.Count > 0) {
            
            #line default
            #line hidden
            this.Write("        ");
            
            #line 71 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(sp.GetMethodDefinitionSync()));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 71 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
 foreach (var p in sp.Params){ 
            
            #line default
            #line hidden
            
            #line 71 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture((p.Order == "1" ? "" : "," )));
            
            #line default
            #line hidden
            
            #line 71 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture((p.isOutput ? "ref " : "" )));
            
            #line default
            #line hidden
            
            #line 71 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Type));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 71 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Param));
            
            #line default
            #line hidden
            
            #line 71 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
}
            
            #line default
            #line hidden
            this.Write(")\r\n        {\r\n           return ");
            
            #line 73 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(sp.Name));
            
            #line default
            #line hidden
            this.Write("Async(");
            
            #line 73 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
 foreach (var p in sp.Params){ 
            
            #line default
            #line hidden
            
            #line 73 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture((p.Order == "1" ? "" : "," )));
            
            #line default
            #line hidden
            
            #line 73 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture((p.isOutput ? "ref " : "" )));
            
            #line default
            #line hidden
            
            #line 73 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Param));
            
            #line default
            #line hidden
            
            #line 73 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
}
            
            #line default
            #line hidden
            this.Write(").Result;\r\n        }\r\n");
            
            #line 75 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
}
            
            #line default
            #line hidden
            
            #line 76 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
 }
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 78 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
 foreach (var sp in SpList){ if (sp.Results.Count > 0){
            
            #line default
            #line hidden
            this.Write("        public class ");
            
            #line 79 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(sp.Name));
            
            #line default
            #line hidden
            this.Write("Result\r\n        {\r\n");
            
            #line 81 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
 foreach (var r in sp.Results){
            
            #line default
            #line hidden
            this.Write("            public ");
            
            #line 82 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(r.Type));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 82 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(r.Name));
            
            #line default
            #line hidden
            this.Write(" { get; set; }\r\n");
            
            #line 83 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
 }
            
            #line default
            #line hidden
            this.Write("        }\r\n\r\n");
            
            #line 86 "C:\Users\egmku\Source\Repos\SPToCore\SPToCore\T4\SPToCoreT4.tt"
 }}
            
            #line default
            #line hidden
            this.Write("    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public class SPToCoreT4Base
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
