#nullable disable

namespace SnakesAndLadders;

class Extension{

    private static readonly int _numNodes = 100;
    private static List<int> breaks;
    public static void generateNodes(Board board){

        for(int i = 0; i < _numNodes; i++){
            Node node = new(i+1);
            board.allNodes.Add(node);
        }

        Console.WriteLine("----Completed Generating Nodes----");
    }

    public static void generatePawns(Board board){
        string strNumPlayers;
        int numPlayers;

        Node startingNode = board.allNodes[0];

        do{
            Console.Clear();
            Console.WriteLine("Enter Number of Players: ");
            strNumPlayers = Console.ReadLine();

            if(string.IsNullOrEmpty(strNumPlayers)){
                Console.WriteLine("Number of Players Cannot be Null!");
                Thread.Sleep(2000);
            }
        } while(string.IsNullOrEmpty(strNumPlayers));

        numPlayers = Convert.ToInt32(strNumPlayers);

        for (int i = 0; i < numPlayers; i++){
            Pawn pawn = new(i);
            pawn.nodeAt = startingNode;
            board.allPawns.Add(pawn);
        }

        Console.WriteLine("----Completed Generating Pawns----");
    }

    public static void printBoard(Board board){

        breaks = new(){11,21,31,41,51,61,71,81,91};

        foreach(Node node in board.allNodes){
            if (breaks.Contains(node.nodeNumber)){
                Console.WriteLine("\n");
            }
            Console.Write($"| {node.nodeNumber.ToString("D2")} |");
        }

        Console.WriteLine("\n----Completed Printing Board----");
    }

    public static int rollDie(){
        Random r = new Random();
        int die = r.Next(1,7);
        return die;
    }
}