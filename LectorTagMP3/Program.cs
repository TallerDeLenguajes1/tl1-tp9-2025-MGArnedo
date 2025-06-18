using Id3v1Tag;
using System.IO;
using System.Text;
Console.WriteLine("===LECTOR TAG ARCHIVO MP3===");
string path = @"F:\taller1\tp9\tl1-tp9-2025-MGArnedo\LectorTagMP3\Silence_PresenceOfMusic.mp3";
if (File.Exists(path))
{
    FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
    fs.Seek(-128, SeekOrigin.End);
    byte[] tagBytes = new byte[128];
    fs.Read(tagBytes, 0, tagBytes.Length);

    string titulo = Encoding.GetEncoding("latin1").GetString(tagBytes, 3, 30).Trim();
    string artista = Encoding.GetEncoding("latin1").GetString(tagBytes, 33, 30).Trim();
    string album = Encoding.GetEncoding("latin1").GetString(tagBytes, 63, 30).Trim();
    string anioDeLaCancion = Encoding.GetEncoding("latin1").GetString(tagBytes, 93, 4).Trim();

    var tag = new Id3v1Tag.Id3v1Tag(titulo, artista, album, anioDeLaCancion);
    Console.WriteLine($"Titulo: {tag.Titulo}");
    Console.WriteLine($"Artista: {tag.Artista}");
    Console.WriteLine($"Album: {tag.Album}");
    Console.WriteLine($"Año: {tag.AnioDeLaCancion}");
    
} else
{
    Console.WriteLine("El directorio no existe.");
}
Console.WriteLine("===FIN DEL PROGRAMA===");
