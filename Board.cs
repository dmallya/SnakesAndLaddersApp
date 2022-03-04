#nullable disable

namespace SnakesAndLadders;

class Board{
    public List<Node> allNodes {get; set;}
    public List<Pawn> allPawns {get; set;}

    public Board(){
        allNodes = new();
        allPawns = new();
    }
}