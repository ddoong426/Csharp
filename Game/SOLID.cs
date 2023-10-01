﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class SOLID
    {
        #region 단일 책임 원칙 - SRP : Single-Responsibility Principle
        // Module, class, function은 하나의 책임만 가져야 합니다.
        // Dog dog = new Dog();
        // 
        // Information info = new Information();
        // 
        // info.Show(dog);
        #endregion

        #region 개방 폐쇄 원칙 - OCP : Open-Closed Principle
        // Module, class, function은 확장에 대해 열려 있어야 하며,
        // 수정에 대해서는 닫혀 있어야 합니다.

        // UnitManager unitManager = new UnitManager();
        // unitManager.Create(new Marine());
        // unitManager.Create(new FireBet());
        // unitManager.Create(new Ghost());
        // unitManager.Create(new Medic());
        #endregion

        #region 인터페이스 분리 원칙 - ISP : Interface Segregation Principle
        // 클라이언트는 자신이 사용하지 않는 함수에 대해
        // 영향을 받지 않아야 하며, 인터페이스를 구체적이고 작은 단위의
        // 역할로 인터페이스를 분리시켜 클라이언트가 꼭 필요한 함수만
        // 이용할 수 있도록 해야합니다.

        // Pistol pistol = new Pistol();
        // Sniper sniper = new Sniper();
        // Rifle rifle = new Rifle();
        // 
        // pistol.Launch();
        // sniper.Launch();
        // sniper.Zoom(50);
        // 
        // rifle.Launch();
        // rifle.Reload();

        #endregion

        #region 의존관계 역전 원칙 - DIP : Dependency Inversion Principle
        // 의존 관계를 맺을 때 자신보다 변화하기 쉬운 것보다는
        // 변화하지 않는 것에 의존해야 합니다.

        // ItemManager itemManager = new ItemManager();
        // itemManager.AddItem(new Potion());
        // itemManager.AddItem(new Gem());
        // itemManager.AddItem(new Stone());
        // 
        // itemManager.UseAll();
        #endregion

        #region 리스코프 치환 원칙 - LSP : Liskov Substitution Principle
        // 상위 클래스와 하위 클래스가 있을 때 상위 클래스 객체를
        // 호출하는 동작에서 하위 클래스 객체가 상위 클래스 객체를
        // 완전하게 대체할 수 있어야 합니다.

        // Rectangle rectangle = new Rectangle();
        // rectangle.SetWidth(5);
        // rectangle.SetHeight(3);
        // 
        // Console.WriteLine("직사각형의 넓이 : " + rectangle.GetArea());
        // 
        // Square square = new Square();
        // square.SetSide(3);
        // 
        // Console.WriteLine("정사각형의 넓이 : "+square.GetArea());
        #endregion
    }
}
