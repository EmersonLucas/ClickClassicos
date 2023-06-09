using NUnit.Framework;
using UnityEngine;

[TestFixture]
public class TestGoal : MonoBehaviour
{
    [Test]
    public void TestExistingGoal()
    {
        var GoalInScene = GameObject.FindAnyObjectByType<Goal>();
        Assert.IsNotNull(GoalInScene);
    }

    [Test]
    public void AmountGoal()
    {
        var GoalInScene = GameObject.FindObjectsOfType<Goal>();
        int GoalCount = GoalInScene.Length;

        Assert.AreEqual(2, GoalCount);

    }

    [Test]
    public void isGoalOne()
    {
        var GoalInScene = GameObject.FindObjectsOfType<Goal>();
        var GoalOne = GoalInScene[1];
        Assert.IsTrue(GoalOne.goalPlayerOne);

    }
    [Test]
    public void isGoalTwo()
    {
        var GoalInScene = GameObject.FindObjectsOfType<Goal>();
        var GoalTwo = GoalInScene[0];
        Assert.IsFalse(GoalTwo.goalPlayerOne);


    }
    [Test]
    public void MakeGoal()
    {
        var GoalOne =  FindAnyObjectByType<GameManager>();
        var GoalTwo = FindAnyObjectByType<GameManager>();

        GoalOne.scorePlayerOne = 1;
        GoalTwo.scorePlayerOne = 1;

        Assert.NotZero(GoalOne.scorePlayerOne);
        Assert.NotZero(GoalTwo.scorePlayerOne);
    }


}
