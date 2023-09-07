//Banda queen = new Banda("Queen");

//Album albumDoQueen = new Album("A Night at the Opera");

//Musica musica1 = new Musica(queen, "Love of my Life")
//{
//    Duracao = 213,
//    Disponivel = true,
//};


//Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
//{
//    Duracao = 353,
//    Disponivel = false,
//};

//albumDoQueen.AdicionarMusica(musica1);
//albumDoQueen.AdicionarMusica(musica2);
//queen.AdicionarAlbum(albumDoQueen);

//musica1.ExibirFichaTecnica();
//musica2.ExibirFichaTecnica();
//albumDoQueen.ExibirMusicasDoAlbum();
//queen.ExibirDiscografia();

Episodio ep1 = new(1, "Space Today - Materia Escura", 45);
ep1.AdicionarConvidados("Claudio Roberto");
ep1.AdicionarConvidados("Marcos Pontes");

Episodio ep2 = new(2, "Space Today - Estamos sozinhos?", 56);
ep2.AdicionarConvidados("Neo");
ep2.AdicionarConvidados("Fernando Marcelo");

Episodio ep3 = new(3, "Space Today - Supercondutores", 48);
ep3.AdicionarConvidados("Rogerinho");
ep3.AdicionarConvidados("Luis Interessante");

Podcast podcast = new("Ciência Sempre", "Serjao dos Foguetes");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.AdicionarEpisodio(ep3);
podcast.ExibirDetalhes();


