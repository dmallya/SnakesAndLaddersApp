#nullable disable

namespace SnakesAndLadders;

class Board{
    public List<Node> allNodes {get; set;}
    public List<Pawn> allPawns {get; set;}

    private static List<int> breaks;

    public Board(){
        allNodes = new();
        allPawns = new();
    }

    public Node getNode(int nodeNumber){
        foreach(Node node in allNodes){
            if (node.nodeNumber == nodeNumber){
                return node;
            }
        }
        return null;
    }

    public void printBoard(){

        Console.OutputEncoding = System.Text.Encoding.UTF8;

        foreach(Node node in allNodes){
            if (node.nodeNumber % 10 == 0){
                Console.WriteLine("\n");
            }

            if(node.nodeState == Node.NodeState.occupied){
                Console.Write("| ◼ |");
                // Console.Write($"| {node.nodeNumber} |");
            }
            else{
                Console.Write("| ◻ |");
                // Console.Write($"| {node.nodeNumber} |");
            }
        }
    }
}