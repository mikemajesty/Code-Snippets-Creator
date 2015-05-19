using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriadorDeSnnipet
{
    public class CodeSnnipet
    {

        private string titulo;

        public string Titulo
        {            
            get { return titulo; }
            set
            {

                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Valor do campo titulo não pode ser vazio!");
                }
                else if (value.Length > 20)
                {
                    throw new Exception("Valor do campo titulo é muito grande!");
                }
                else
                {
                    titulo = value;
                }
              
            }
        }
        private string atalho;

        public string Atalho
        {
            get { return atalho; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                     throw new Exception("Valor do campo atalho não pode ser vazio!");
                }
                else if (value.Length > 10)
                {
                    throw new Exception("Valor do campo atalho é muito grande!");
                }              
                else
                {
                    atalho = value;
                }
              
            }
        }
        private string descricao;

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        private string autor;

        public string Autor
        {
            get { return autor; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Valor do campo autor não pode ser vazio!");
                }
                else if (value.Length > 15)
                {
                    throw new Exception("Valor do campo autor é muito grande!");
                }
                else
                {
                    autor = value;
                }
             
            }
        }
        private string codigo;

        public string Codigo
        {
            get { return codigo; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Valor do campo autor não pode ser vazio!");
               }               
                else
                {
                    codigo = value;
                }
               
            }
        }
        
      

        public string CriarSnnipet()
        {
            try
            {

                StringBuilder ap = new StringBuilder();
                ap.AppendLine("<?xml version='1.0' encoding='utf-8' ?>");
                ap.AppendLine("<CodeSnippets  xmlns='http://schemas.microsoft.com/VisualStudio/2005/CodeSnippet>'>");
                ap.AppendLine("<CodeSnippet Format='1.0.0'>");
                ap.AppendLine("<Header>");
                ap.AppendLine("<Title>" + this.Titulo + "</Title>");
                ap.AppendLine("<Shortcut>"+this.Atalho+"</Shortcut>");
                ap.AppendLine("<Description>"+this.Descricao+"</Description>");
                ap.AppendLine("<Author>"+this.Autor+"</Author>");
                ap.AppendLine("<SnippetTypes>");
                ap.AppendLine("<SnippetType>Expansion</SnippetType>");
                ap.AppendLine("<SnippetType>SurroundsWith</SnippetType>");
                ap.AppendLine("</SnippetTypes>");
                ap.AppendLine("</Header>"); 
                ap.AppendLine("<Snippet>");
                ap.AppendLine("<Code Language='csharp'><![CDATA[");
                ap.AppendLine(this.Codigo);
                ap.AppendLine("]]>");
                ap.AppendLine("</Code>");
                ap.AppendLine("</Snippet>");
                ap.AppendLine("</CodeSnippet>");
                ap.AppendLine("</CodeSnippets>");
                return ap.ToString();
            }
            catch (Exception erro)
            {                
                throw new Exception(erro.Message);
            }
        }

        /*<?xml version="1.0" encoding="utf-8" ?>
<CodeSnippets  xmlns="http://schemas.microsoft.com/VisualStudio/2005/CodeSnippet">
	<CodeSnippet Format="1.0.0">
		<Header>
			<Title>Cria Um Metodo Com TryCatch</Title>
			<Shortcut>tccm</Shortcut>
			<Description>Code snippet for class</Description>
			<Author>Mike Rodrigues De Lima</Author>
			<SnippetTypes>
				<SnippetType>Expansion</SnippetType>
				<SnippetType>SurroundsWith</SnippetType>
			</SnippetTypes>
		</Header>
		<Snippet>
			
			<Code Language="csharp"><![CDATA[
			   public bool MyMethod()
        {
            try
            {
                return true;
            }
            catch (Exception Erro)
            {
                
                throw new Exception(Erro.Message);
            }
        }
        
		]]>
			</Code>
		</Snippet>
	</CodeSnippet>
</CodeSnippets>*/
    }
}
