using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TileSwapper : MonoBehaviour
{
    [Tooltip("Associate the tiles into this array")]
    public List<GameObject> mTiles;

    [Tooltip("Associate the location transforms into this array")]
    public Transform[] mTileLocations;

    public Button buttonUp, buttonDown, buttonLeft, buttonRight;

    enum Directions
    {
        up,
        down,
        left,
        right
    }

    Directions direction;

    private void Start()
    {

    }

    private void Update()
    {
        
    }

    //public void MoveTile(int indexOfTile, Directions moveDirection)
    //{
    //    switch (indexOfTile)
    //    {
    //        case 0:
    //            if (direction == Directions.right)
    //            {
    //                mTiles.Insert(1, mTiles[indexOfTile]);
    //                mTiles.RemoveAt(indexOfTile);
    //            }
    //            else if (direction == Directions.down)
    //            {
    //                mTiles.Insert(3, mTiles[indexOfTile]);
    //                mTiles.RemoveAt(indexOfTile);
    //            }
    //            break;
    //        case 1:
    //            if (direction == Directions.left)
    //            {
    //                mTiles.Insert(0, mTiles[indexOfTile]);
    //                mTiles.RemoveAt(indexOfTile);
    //            }
    //            else if (direction == Directions.right)
    //            {
    //                mTiles.Insert(2, mTiles[indexOfTile]);
    //                mTiles.RemoveAt(indexOfTile);
    //            }
    //            else if (direction == Directions.down)
    //            {
    //                mTiles.Insert(4, mTiles[indexOfTile]);
    //                mTiles.RemoveAt(indexOfTile);
    //            }
    //            break;
    //        case 2:
    //            if (direction == Directions.left)
    //            {
    //                mTiles.Insert(1, mTiles[indexOfTile]);
    //                mTiles.RemoveAt(indexOfTile);
    //            }
    //            else if (direction == Directions.down)
    //            {
    //                mTiles.Insert(5, mTiles[indexOfTile]);
    //                mTiles.RemoveAt(indexOfTile);
    //            }
    //            break;
    //        case 3:
    //            if (direction == Directions.up)
    //            {
    //                mTiles.Insert(0, mTiles[indexOfTile]);
    //                mTiles.RemoveAt(indexOfTile);
    //            }
    //            else if (direction == Directions.down)
    //            {
    //                mTiles.Insert(6, mTiles[indexOfTile]);
    //                mTiles.RemoveAt(indexOfTile);
    //            }
    //            else if (direction == Directions.right)
    //            {
    //                mTiles.Insert(4, mTiles[indexOfTile]);
    //                mTiles.RemoveAt(indexOfTile);
    //            }
    //            break;
    //        case 4:
    //            if (direction == Directions.up)
    //            {
    //                mTiles.Insert(1, mTiles[indexOfTile]);
    //                mTiles.RemoveAt(indexOfTile);
    //            }
    //            else if (direction == Directions.down)
    //            {
    //                mTiles.Insert(7, mTiles[indexOfTile]);
    //                mTiles.RemoveAt(indexOfTile);
    //            }
    //            else if (direction == Directions.left)
    //            {
    //                mTiles.Insert(3, mTiles[indexOfTile]);
    //                mTiles.RemoveAt(indexOfTile);
    //            }
    //            else if (direction == Directions.right)
    //            {
    //                mTiles.Insert(5, mTiles[indexOfTile]);
    //                mTiles.RemoveAt(indexOfTile);
    //            }
    //            break;
    //        case 5:
    //            if (direction == Directions.up)
    //            {
    //                mTiles.Insert(2, mTiles[indexOfTile]);
    //                mTiles.RemoveAt(indexOfTile);
    //            }
    //            else if (direction == Directions.down)
    //            {
    //                mTiles.Insert(8, mTiles[indexOfTile]);
    //                mTiles.RemoveAt(indexOfTile);
    //            }
    //            else if (direction == Directions.left)
    //            {
    //                mTiles.Insert(4, mTiles[indexOfTile]);
    //                mTiles.RemoveAt(indexOfTile);
    //            }
    //            break;
    //        case 6:
    //            if (direction == Directions.up)
    //            {
    //                mTiles.Insert(3, mTiles[indexOfTile]);
    //                mTiles.RemoveAt(indexOfTile);
    //            }
    //            else if (direction == Directions.right)
    //            {
    //                mTiles.Insert(7, mTiles[indexOfTile]);
    //                mTiles.RemoveAt(indexOfTile);
    //            }
    //            break;
    //        case 7:
    //            if (direction == Directions.up)
    //            {
    //                mTiles.Insert(4, mTiles[indexOfTile]);
    //                mTiles.RemoveAt(indexOfTile);
    //            }
    //            else if (direction == Directions.left)
    //            {
    //                mTiles.Insert(6, mTiles[indexOfTile]);
    //                mTiles.RemoveAt(indexOfTile);
    //            }
    //            else if (direction == Directions.right)
    //            {
    //                mTiles.Insert(8, mTiles[indexOfTile]);
    //                mTiles.RemoveAt(indexOfTile);
    //            }
    //            break;
    //        case 8:
    //            if (direction == Directions.up)
    //            {
    //                mTiles.Insert(5, mTiles[indexOfTile]);
    //                mTiles.RemoveAt(indexOfTile);
    //            }
    //            else if (direction == Directions.left)
    //            {
    //                mTiles.Insert(7, mTiles[indexOfTile]);
    //                mTiles.RemoveAt(indexOfTile);
    //            }
    //            break;
    //    }
    //}

    public void SetPuzzleState()
    {
        for (int i = 0; i < mTileLocations.Length; ++i)
        {

        }
    }

    public IEnumerator Coroutine_MoveOverSeconds(
    GameObject objectToMove,
    Vector3 end,
    float seconds)
    {
        float elapsedTime = 0;
        Vector3 startingPos = objectToMove.transform.position;
        while (elapsedTime < seconds)
        {
            objectToMove.transform.position = Vector3.Lerp(
                startingPos, end,
                (elapsedTime / seconds));
            elapsedTime += Time.deltaTime;

            yield return new WaitForEndOfFrame();
        }
        objectToMove.transform.position = end;
    }
}
