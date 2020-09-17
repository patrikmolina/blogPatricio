using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Mvc;

namespace blogPatricio.Models
{
    public class DbActions
    {
        private SqlConnection con;

        private void Conectar()
        {
            string constr = ConfigurationManager.ConnectionStrings["ContextBlog"].ToString();
            con = new SqlConnection(constr);
        }

        public int Create(Post po) 
        {
            Conectar();
            SqlCommand comando = new SqlCommand("insert into blog_entrada(Titulo, Contenido, Imagen, Categoria, Fecha_Creacion) values (@Titulo, @Contenido, @Imagen, @Categoria, @FechaCreacion)", con);
            comando.Parameters.Add("@Titulo", SqlDbType.VarChar);
            comando.Parameters.Add("@Contenido", SqlDbType.VarChar);
            comando.Parameters.Add("@Imagen", SqlDbType.VarChar);
            comando.Parameters.Add("@Categoria", SqlDbType.VarChar);
            comando.Parameters.Add("@FechaCreacion", SqlDbType.DateTime);
            comando.Parameters["@Titulo"].Value = po.Titulo;
            comando.Parameters["@Contenido"].Value = po.Contenido;
            comando.Parameters["@Imagen"].Value = po.Imagen;
            comando.Parameters["@Categoria"].Value = po.Categoria;
            comando.Parameters["@FechaCreacion"].Value = po.FechaCreacion;

            con.Open();
            int i = comando.ExecuteNonQuery();
            con.Close();
            return i;
        }

        public int Edit(Post po)
        {
            Conectar();
            SqlCommand comando = new SqlCommand("update blog_entrada set Titulo=@Titulo, Contenido=@Contenido, Imagen=@Imagen, Categoria=@Categoria where Id=@Id", con);
            comando.Parameters.Add("@Titulo", SqlDbType.VarChar);
            comando.Parameters.Add("@Contenido", SqlDbType.VarChar);
            comando.Parameters.Add("@Imagen", SqlDbType.VarChar);
            comando.Parameters.Add("@Categoria", SqlDbType.VarChar);
            comando.Parameters.Add("@Id", SqlDbType.Int);
            comando.Parameters["@Titulo"].Value = po.Titulo;
            comando.Parameters["@Contenido"].Value = po.Contenido;
            comando.Parameters["@Imagen"].Value = po.Imagen;
            comando.Parameters["@Categoria"].Value = po.Categoria;
            comando.Parameters["@Id"].Value = po.Id;
            con.Open();
            int i = comando.ExecuteNonQuery();
            con.Close();
            return i;
        }

        public Post getPost(int Id)
        {
            Conectar();
            SqlCommand comando = new SqlCommand("select Id, Titulo, Contenido, Imagen, Categoria from blog_entrada where Id=@Id", con);
            comando.Parameters.Add("@Id", SqlDbType.Int);
            comando.Parameters["@Id"].Value = Id;
            con.Open();
            SqlDataReader registros = comando.ExecuteReader();
            Post po = new Post();
            if (registros.Read()) 
            {
                po.Id = int.Parse(registros["id"].ToString());
                po.Titulo = registros["Titulo"].ToString();
                po.Contenido = registros["Contenido"].ToString();
                po.Imagen = registros["Imagen"].ToString();
                po.Categoria = registros["Categoria"].ToString();
            }
            con.Close();
            return po;
        }

        public int Delete(int Id)
        {
            Conectar();
            SqlCommand comando = new SqlCommand("delete from blog_entrada where id=@id", con);
            comando.Parameters.Add("@id", SqlDbType.Int);
            comando.Parameters["@id"].Value = Id;
            con.Open();
            int i = comando.ExecuteNonQuery();
            con.Close();
            return i;
        }



    }
}
