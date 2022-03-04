#nullable disable

namespace SnakesAndLadders;
class Program{

    private static Board _board;
    static void Main(){

        init();

        if (_board == null){
            throw new InvalidDataException();
        }

        Extension.printBoard(_board);
    }

    static void init(){
        Board board = new();
        Extension.generateNodes(board);
        Extension.generatePawns(board);
        _board = board;

        Console.WriteLine("----Completed Initializing Game----");
    }
}