using System;

State state = State.Idle;
int choice;

Array states = Enum.GetValues(typeof(State));

Console.WriteLine("=== 캐릭터 상태 관리 ===");

while (true)
{
    Console.WriteLine($"\n현재 상태: {state}\n");

    Console.WriteLine("1. 상태 변경\n2. 상태 목록 보기\n3. 현재 행동 보기\n4. 종료");
    Console.Write("선택: ");

    choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.Write("\n변경할 상태 번호 입력 (0-5): ");
            choice = int.Parse(Console.ReadLine());
            state = (State)choice;
            Console.WriteLine($"상태가 {state}(으)로 변경되었습니다.");
            break;

        case 2:
            Console.WriteLine("\n=== 상태 목록 ===");
            foreach (State s in states) Console.WriteLine($"{s} = {(int)s}");
            break;

        case 3:
            switch (state)
            {
                case State.Idle:
                    Console.WriteLine($"\n[행동] 대기합니다.");
                    break;
                case State.Walking:
                    Console.WriteLine($"\n[행동] 걷습니다.");
                    break;
                case State.Running:
                    Console.WriteLine($"\n[행동] 달립니다.");
                    break;
                case State.Jumping:
                    Console.WriteLine($"\n[행동] 점프합니다.");
                    break;
                case State.Attacking:
                    Console.WriteLine($"\n[행동] 적을 공격합니다.");
                    break;
                case State.Dead:
                    Console.WriteLine($"\n[행동] 사망 상태입니다.");
                    break;
            }
            break;

        case 4:
            Console.WriteLine("\n프로그램을 종료합니다.");
            return;
    }
}

enum State
{
    Idle,
    Walking,
    Running,
    Jumping,
    Attacking,
    Dead
}