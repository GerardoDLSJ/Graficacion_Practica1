using SharpGL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graficacione3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openGLControl1.Size = this.Size;
        }

        private void openGLControl1_Load(object sender, EventArgs e)
        {

        }

        private void openGLControl1_OpenGLInitialized(object sender, EventArgs e)
        {
            OpenGL gl = openGLControl1.OpenGL;
            gl.ClearColor(0, 0, 0, 0);
        }

        private void openGLControl1_Resize(object sender, EventArgs e)
        {
            OpenGL gl = openGLControl1.OpenGL;

            //    Ajuste el modo de matriz actual, aplique la operación de la matriz posterior a la matriz de proyección
            gl.MatrixMode(OpenGL.GL_PROJECTION);

            //  Restablecer la matriz actualmente especificada como una matriz de unidades, mueva el origen del sistema de coordenadas de usuario actual al centro de la pantalla
            gl.LoadIdentity();

            //  Crea una transformación de proyección en perspectiva.
            gl.Perspective(30.0f, (double)Width / (double)Height, 5, 100.0);

            //  Transformación de punto de vista
            gl.LookAt(-5, 5, -5, 0, 0, 0, 0, 1, 0);

            //  Establezca la matriz actual como una matriz de vista modelo
            gl.MatrixMode(OpenGL.GL_MODELVIEW);
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
        }

        private void openGLControl1_OpenGLDraw(object sender, RenderEventArgs args)
        {
            SharpGL.OpenGL gl = this.openGLControl1.OpenGL;
            gl.LoadIdentity();
            gl.Translate(-1.5f, 0f, -6f);
            gl.Begin(OpenGL.GL_QUADS);

            {
                gl.Vertex(-0.1f, 2.0f, 0.0f);
                gl.Vertex(1.0f, 2.0f, 0.0f);
                gl.Vertex(1.0f, -2.0f, 0.0f);
                gl.Vertex(-0.1f, -2.0f, 0.0f);
            }

            gl.End();
            // Mueve el sistema de coordenadas actual 3 unidades, presta atención a esto en este momento {-1.5,0,-5}
            gl.Translate(1.13f, 0f, 0f);

            gl.Begin(OpenGL.GL_QUADS);

            {
                gl.Vertex(-0.1f, 2.0f, 0.0f);
                gl.Vertex(1.0f, 2.0f, 0.0f);
                gl.Vertex(1.0f, -2.0f, 0.0f);
                gl.Vertex(-0.1f, -2.0f, 0.0f);
            }

            gl.End();

            // Mueve el sistema de coordenadas actual 3 unidades, presta atención a esto en este momento {-1.5,0,-5}
            gl.Translate(1.13f, 0f, 0f);

            gl.Begin(OpenGL.GL_QUADS);

            {
                gl.Vertex(-0.1f, 2.0f, 0.0f);
                gl.Vertex(1.0f, 2.0f, 0.0f);
                gl.Vertex(1.0f, -2.0f, 0.0f);
                gl.Vertex(-0.1f, -2.0f, 0.0f);
            }
            gl.End();

            // Mueve el sistema de coordenadas actual 3 unidades, presta atención a esto en este momento {-1.5,0,-5}
            gl.Translate(1.13f, 0f, 0f);

            gl.Begin(OpenGL.GL_QUADS);
            {
                gl.Vertex(-0.1f, 2.0f, 0.0f);
                gl.Vertex(1.0f, 2.0f, 0.0f);
                gl.Vertex(1.0f, -2.0f, 0.0f);
                gl.Vertex(-0.1f, -2.0f, 0.0f);
            }
            gl.End();

            gl.Flush(); //Actualizacion forzada


        }
    }
}
