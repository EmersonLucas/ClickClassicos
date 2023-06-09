using NUnit.Framework;
using UnityEngine;


[TestFixture]
public class TestPlayer : MonoBehaviour
{
    [Test]
    public void TestExistingPlayer()
    {
        var PlayerInScene = GameObject.FindAnyObjectByType<ControllerPlayers>();
        Assert.IsNotNull(PlayerInScene) ;
    }

    [Test]
    public void AmountPlayer()
    {
        var playersInScene = GameObject.FindObjectsOfType<ControllerPlayers>();
        int playerCount = playersInScene.Length;

        Assert.AreEqual(2, playerCount);    

    }

    [Test]
    public void isPlayerOne()
    {
        var playersInScene = GameObject.FindObjectsOfType<ControllerPlayers>();
        var playerOne = playersInScene[1];

        Assert.IsTrue(playerOne.playerOne);
     
    }
    [Test]
    public void isPlayerTwo()
    {
        var playersInScene = GameObject.FindObjectsOfType<ControllerPlayers>();
        var playerTwo = playersInScene[0];

        Assert.IsFalse(playerTwo.playerOne);

    }
    [Test]
    public void MovePlayer()
    {
        var playersInScene = GameObject.FindObjectsOfType<ControllerPlayers>();
        var playerOne = playersInScene[1];
        var playerTwo = playersInScene[0];

        playerOne.transform.position = new Vector3(0, 5, 0);
        Assert.IsTrue(playerOne.transform.position.y != 0);

        playerTwo.transform.position = new Vector3(0, 5, 0);
        Assert.IsTrue(playerTwo.transform.position.y != 0);

    }


}



