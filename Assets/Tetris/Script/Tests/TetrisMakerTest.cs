using NUnit.Framework;
using Zenject;
using UnityEngine;
using UniRx;

namespace Tetris.Test
{
    [TestFixture]
    public class TetrisMakerTest : ZenjectUnitTestFixture
    {
        [SetUp]
        public void Binding() 
        {
            Container
                .Bind<TetrominoMaker>()
                .AsSingle();
        }
        
        [Test]
        public void MakerTest()
        {
            for(int i = 1; i <= 30; i++) 
            {
                Random.InitState(i);

                var random = Random.Range(1, 7);

                Debug.Log(string.Format("{0} {1}", i, random));
            }
        }
    }
}