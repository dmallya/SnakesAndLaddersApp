#nullable disable

namespace SnakesAndLadders;

class Pawn{

    private int pawnNumber;
    public Node nodeAt {get; set;}

    public Pawn(int pawnNumber){
        this.pawnNumber = pawnNumber;
    }
}