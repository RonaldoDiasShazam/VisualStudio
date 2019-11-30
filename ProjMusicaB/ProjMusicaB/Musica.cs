using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjMusicaB
{
    class Musica
    {
        private string titulo;

        private int genero;

        private string artista;

        private int nroFaixa;

        private string album;
        public string getAlbum()
        {
            return album;
        }
        public void setAlbum(string alb)
        {
            album = alb;
        }

        public int getNroFaixa()
        {
            return nroFaixa;
        }
        public void setNroFaixa(int nro)
        {
            if (nro != 0)
                nroFaixa = nro;
        }

        public void setTitulo(string tit)
        {
            titulo = tit;
        }
        public string getTitulo()
        {
            return titulo;
        }
        public void setGenero(int gen)
        {
            genero = gen;
        }
        public int getGenero()
        {
            return genero;
        }
        public string getArtista()
        {
            return artista;
        }
        public void setArtista(string art)
        {
            artista = art;
        }
    }
}
