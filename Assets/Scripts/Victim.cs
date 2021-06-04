using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victim : MonoBehaviour
{
    float minX = -6.4f;
    float maxX = 6.4f;
    float maxY = 4.55f;
    float minY = -4.62f;

    float _speed = 3f;
    float _changeDirectionMin = 0.01f;
    float _changeDirectionMax = 0.4f;

    bool moveUp, moveDown,moveLeft,moveRight;

    [SerializeField] int _direction;
    //directions:
    //0 up
    //1 down
    //2 left
    //3 right

    void Start()
    {
        StartCoroutine(PickADirection());
        
    }
    
    
    void Update()
    {
        MoveDirection();
        CheckBorders();
    }
 
    

    IEnumerator PickADirection()
    {
        while(true)
        {
            float numSec = Random.Range(_changeDirectionMin,_changeDirectionMax);
            yield return new WaitForSeconds(numSec);
            int _direction = Random.Range(0,4);
            yield return new WaitForEndOfFrame();
        }
    }

    void MoveUp()
    {
        if(moveUp)
        {
            transform.Translate(Vector2.up * _speed * Time.deltaTime);
        }
    }
    void MoveDown()
    {
        if(moveDown)
        {
            transform.Translate(Vector2.down * _speed * Time.deltaTime);
        }
    }
    void MoveRight()
    {
        if(moveRight)
        if(true)
        {
            transform.Translate(Vector2.right * _speed * Time.deltaTime);
        }
    }
    void MoveLeft()
    {
        if(moveLeft)
        {
        transform.Translate(Vector2.left * _speed * Time.deltaTime);
        }
    }

    void MoveDirection()
    {
            if(_direction == 0)
            {
                moveUp=true;
                moveDown=false;
                moveRight=false;
                moveLeft=false;
                MoveUp();
            }
            if(_direction == 1)
            {   
                moveUp=false;
                moveDown=true;
                moveRight=false;
                moveLeft=false;
                MoveDown();
            }
            if(_direction == 2)
            {  
                moveUp=false;
                moveDown=false;
                moveRight=false;
                moveLeft=true;
                MoveLeft();

            }
            if(_direction == 3)
            {   
                moveUp=false;
                moveDown=false;
                moveRight=true;
                moveLeft=false;
                MoveRight();
            }
    }
    void CheckBorders()
    {
        if (transform.position.x < minX)
        {
            _direction = 3;
        }

        if(transform.position.x > maxX)
        {
            _direction = 2;
        }
        if(transform.position.y < minY)
        {
            _direction = 0;
        }
                if(transform.position.y < maxY)
        {
            _direction = 1;
        }  
    }
}