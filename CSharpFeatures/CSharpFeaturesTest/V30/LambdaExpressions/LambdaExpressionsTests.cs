﻿// 참고:
// Lambda Expressions (C# Programming Guide) - msdn
// http://msdn.microsoft.com/en-us/library/bb397687

using Xunit;
using System;

namespace CSharpFeaturesTest.V30.LambdaExpressions
{
    
    public class LambdaExpressionsTests
    {
        delegate int _del(int input);

        [Fact]
        public void LambdaExpressionsTest()
        {
            // =>는 goes to라고 읽는다.
            _del myDel = x => x * x;
            Assert.Equal(5 * 5, myDel(5));

            // 컴파일러가 타입 추론을 힘들어 할 때가 있는데, 그땐 이렇게 type을 명시해서 도울 수 있다.
            // 친절한 자. 컴파일러가 돕는다.
            _del myDel2 = (int x) => x * x;
            Assert.Equal(5 * 5, myDel2(5));

            // statement도 사용가능
            _del myDel3 = x =>
                {
                    int sum = 0;
                    for (int i = 0; i < x; ++i)
                    {
                        sum += x;
                    }

                    return sum;
                };
            Assert.Equal(5 * 5, myDel3(5));
        }

        [Fact]
        public void FuncTest()
        {
            // System에 정의한 generics delegate.
            // custom delegate를 정의하는 수고를 없앤다. 
            // 게다가 이리저리 연동하기도 좋으니 커스텀 보다는 Func를 사용
            Func<int, bool> myFunc = x => x == 5;
            Assert.True(myFunc(5));
            Assert.False(myFunc(4));
        }

        [Fact]
        public void ActionTest()
        {
            int n = 0;

            // Func<>에 void return은 불가능. 이런 경우엔 Action을 사용
            // Func<int, void> myFunc = x => n += x;
            Action<int> myAction = x => n += x;

            myAction(5);
            Assert.True(5 == n, "n은 myAction에서 capture");
        }

        class Scope
        {
            // parameter, return type이 없을 때는 Action
            public Action myAction;
            public Func<int, bool> myFunc2;
            
            public void Init()
            {
                int j = 0;

                myAction = () =>
                    {
                        j = 10;
                    };

                myFunc2 = (x) =>
                    {
                        return x == j;
                    };

                // invoke
                myAction();
            }
        }

        [Fact]
        public void ScopeTest()
        {
            Scope s = new Scope();
            s.Init();

            Assert.True(
                s.myFunc2(10), 
                "Init() 안에서 myAction() 호출. j에 10을 할당. 함수가 종료 후 j가 해제될 것 같지만 myFunc2에서 캡쳐. 그래서 10이 살아있다.");
        }
    }
}
