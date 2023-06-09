using UnityEngine;
using NUnit.Framework;

[TestFixture]
public class TestBall : MonoBehaviour
{
    [Test]
    public void TestExistingBall()
    {
        var BallInScene = GameObject.FindAnyObjectByType<Ball>();
        Assert.IsNotNull(BallInScene);
    }

    [Test]
    public void AmountBall()
    {
        var BallInScene = GameObject.FindObjectsOfType<Ball>();
        int BallCount = BallInScene.Length;

        Assert.AreEqual(1, BallCount);

    }

    [Test]
    public void MoveBall()

    {
        var BallInScene = GameObject.FindAnyObjectByType<Ball>();
        BallInScene.transform.position = new Vector3(4, 5, 0);
        Assert.IsTrue(BallInScene.transform.position.x != 0);
        Assert.IsTrue(BallInScene.transform.position.y != 0);

    }
}