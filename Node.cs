using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public List<Vector2> availibleDirections {get; private set;}
    public LayerMask obstacleLayer; 

    private void Start(){
        this.availibleDirections = new List<Vector2>();
        CheckAvailibleDirection(Vector2.up);
        CheckAvailibleDirection(Vector2.down);
        CheckAvailibleDirection(Vector2.left);
        CheckAvailibleDirection(Vector2.right);
    }

    private void CheckAvailibleDirection(Vector2 direction){
        RaycastHit2D hit = Physics2D.BoxCast(this.transform.position, Vector2.one * 0.5f, 0.0f, direction, 1.0f, this.obstacleLayer);

        if(hit.collider == null){
            this.availibleDirections.Add(direction);
        }
    }
}
