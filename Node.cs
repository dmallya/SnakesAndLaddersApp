#nullable disable

namespace SnakesAndLadders;

class Node{
    public int nodeNumber {get; set;}
    private Node ladderNode {get; set;}
    private Node snakeNode{get; set;}

    public Node(int nodeNumber){
        this.nodeNumber = nodeNumber;
    }
}