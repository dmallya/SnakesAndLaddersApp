#nullable disable

namespace SnakesAndLadders;

class Extension{

    private static readonly int _numNodes = 100;
    public static void generateNodes(Board board){

        for(int i = _numNodes; i > 1; i--){
            Node node = new(i);
            node.nodeState = Node.NodeState.unoccupied;
            board.allNodes.Add(node);
        }

        Node startingNode = new(1);
        startingNode.nodeState = Node.NodeState.occupied;
        board.allNodes.Add(startingNode);

        Console.WriteLine(board.allNodes.Count);

        Console.WriteLine("----Completed Generating Nodes----\n");
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

        Console.WriteLine("----Completed Generating Pawns----\n");
    }

    public static int rollDie(){
        Random r = new Random();
        int die = r.Next(1,7);
        return die;
    }
}