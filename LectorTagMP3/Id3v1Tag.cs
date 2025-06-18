/*El programa deberá leer esta información, cargar en una instancia de una clase Id3v1Tag y luego 
mostrar por consola el título, artista, álbum y año de la canción.*/
namespace Id3v1Tag {
    public class Id3v1Tag
    {
        private string titulo { get; set; }
        private string artista { get; set; }
        private string album { get; set; }
        private string anioDeLaCancion { get; set; }

        public Id3v1Tag(string titulo, string artista, string album, string anioDeLaCancion)
        {
            this.titulo = titulo;
            this.artista = artista;
            this.album = album;
            this.anioDeLaCancion = anioDeLaCancion;
        }

        public string Titulo
        {
            get => titulo;
        }
        public string Artista
        {
            get => artista;
        }
        public string Album
        {
            get => album;
        }
        public string AnioDeLaCancion
        {
            get => anioDeLaCancion;
        }
    }
}