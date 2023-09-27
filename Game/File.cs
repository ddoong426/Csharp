using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Monster
    {
        public int hp;

        protected void Move()
        {
            Console.WriteLine("몬스터 이동");
        }
    }

    public class Goblin : Monster
    {
        #region base 키워드
        // 하위 클래스에서 상위 클래스의 속성과 기능을
        // 접근할 수 있는 지정자입니다.
        public Goblin()
        {
            hp = 100;
            base.Move();
        }
        #endregion

        // 함수 앞에 new : 오버라이딩
        new public void Move()
        {
            Console.WriteLine("고블린 이동");
        }
    }

    public class Slime : Monster
    {
        public Slime()
        {
            hp = 125;

        }
    }

    public class Skeleton : Monster
    {
        public Skeleton()
        {
            hp = 200;
        }
    }

    public class Damagable
    {
        public void Damage(Monster monster)
        {
            monster.hp -= 10;
        }
    }
    internal class File
    {
        static void Main(string[] args)
        {
            #region 업캐스팅
            // Damagable damagable = new Damagable();
            // Goblin goblin = new Goblin();
            // Skeleton skeleton = new Skeleton();
            // Console.WriteLine("고블린의 체력 : " + goblin.hp);
            // Console.WriteLine("스켈레톤의 체력 : " + skeleton.hp);
            // damagable.Damage(goblin);
            // damagable.Damage(skeleton);
            // Console.WriteLine("고블린의 체력 : " + goblin.hp);
            // Console.WriteLine("스켈레톤의 체력 : " + skeleton.hp);
            #endregion

            #region 파일 입출력

            // 파일 쓰기
            // FileStream fileStream = new FileStream("data.txt", FileMode.Create);
            // 
            // StreamWriter streamWriter=new StreamWriter(fileStream);
            // 
            // streamWriter.Write("HELLO");
            // streamWriter.Write(25);
            // 
            // streamWriter.Close();

            // 파일 읽기
            // FileStream file = new FileStream("data.txt", FileMode.Open, FileAccess.Read);
            // StreamReader streamReader = new StreamReader(file);
            //
            //     Console.WriteLine(streamReader.ReadLine());
            //
            // streamReader.Close();
            #endregion

            #region 최대 공약수
            // int x =int.Parse(Console.ReadLine());
            // int y = int.Parse(Console.ReadLine());
            // int result = 0;
            // 
            // for (int i = 1; i <= x && i <= y; i++)
            // {
            //     if (x % i == 0 && y % i == 0)
            //     {
            //         result = i;
            //     }
            // }
            // 
            // Console.WriteLine("최대 공약수 : " + result);
            #endregion
        }
    }
}
