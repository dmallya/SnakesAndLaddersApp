#nullable disable

namespace SnakesAndLadders;

class Node{
    public enum NodeState {
        occupied,
        unoccupied
    }
    public int nodeNumber {get; set;}
    public Node ladderNode {get; set;}
    public Node snakeNode{get; set;}
    public NodeState nodeState{get;set;}

    public Node(int nodeNumber){
        this.nodeNumber = nodeNumber;
    }
}