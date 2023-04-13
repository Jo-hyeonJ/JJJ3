// See https://aka.ms/new-console-template for more information
// 1교시
/*
{
    Console.WriteLine("Hello, World!");
    // 연산자
    // = 데이터를 다룰 수 있도록 해주는 기호

    // 산술 연산자
    // +,-,*,/,%,=

    int number = 3 + 4;
    Console.WriteLine(number);

    // 나누기할 때 둘 다 int면 int의 결과가 나온다
    // 좌측 혹은 우측하나라도 실수형이라면 실수형이 나온다.
    // 어떠한 수를 0으로 나눌 수는 없다.

    float num1 = 10 / 4.0f; // 10.0같은 기호가 붙지 않은 소수는 double 형태이기 때문에 float를 사용할 때 주의
    Console.WriteLine(num1);

    int n1 = 10;
    int n2 = 20;
    float n3 = 3.0f;
    double n4 = 5.0;

    // 나누기로 인한 형변환

    float n5 = n1 / n2; // 값은 0.5지만 결과가 int이기 때문에 0이 나온다
    Console.WriteLine($"n1/n2 = {n5}");

    // int / float는 결과가 float다.
    float n6 = n2 / n3;
    Console.WriteLine($"n2/n3 = {n6}");

    // float / double은 결과가 double이다.
    double n7 = n3 / n4;
    Console.WriteLine($"n3/n4 = {n7}");


    // 모듈러 연산 (%)

    Console.WriteLine($"100%3 = {100 % 3}");

    // 증감 연산자 (++, --)
    // 값을 1 증가시키거나 1감소시키는 연산자다.

    int score = 10;
    score++; // score = score + 1;
    score--; // score = score - 1;
    Console.WriteLine($"score는 {score}");
    Console.WriteLine($"score++는 {score++}"); // 후위 증가 연산자
    Console.WriteLine($"++score는 {++score}"); // 전위 증가 연산자
    Console.WriteLine();
    // 연산자의 우선순위
    // 괄호 우선, 증감 기호, 곱하기 나눗셈 이후 덧셈뺄셈 (자세한건 검색)

    // Q. 산술 이용해 값을 계산해보자.
    int q1 = 10;
    int q2 = 4;


    Console.WriteLine($"q1 = {q1}");
    Console.WriteLine($"q2 = {q2}");
    Console.WriteLine($"q1 + q2 = {q1 + q2}");
    Console.WriteLine($"q1 - q2 = {q1 - q2}");
    Console.WriteLine($"q1 * q2 = {q1 * q2}");
    Console.WriteLine($"q1 / q2 = {(double)q1 / q2}"); // (double)(q1 / q2)로 연산시 (q1 / q2)에서 미리 int가 되어버린다. = 2/ 때문에 미리 q1을 형변환한다.  
    Console.WriteLine($"q1 % q2 = {q1 % q2}");

    // 문자열 결합 연산자
    // 여러 문자열을 합쳐주는 연산자

    int result1 = 123 + 456; // 579
    string result2 = "123" + "456"; // "123456" 

    Console.WriteLine(result1);
    Console.WriteLine(result2);

    result2 = "123" + 456; // 숫자 + 문자열 = 문자열. "123456" 문자열 우선 순위가 높기 때문에 문자열과 연산 시, int 또한 문자열이 된다.
}
*/

// 2교시
/*
    // 비교 연산자
// = 특정 두 값을 비교할 수 있다. (결과 값이 bool 형식이다.)

int a = 10;
int b = 10;

Console.WriteLine($"a < b : {a < b}"); // a가 b보다 작다 (미만)
Console.WriteLine($"a > b : {a > b}"); // a가 b보다 크다 (초과)
Console.WriteLine($"a <= b : {a <= b}"); // a가 b보다 작거나 같다 (이하)
Console.WriteLine($"a <= b : {a >= b}"); // a가 b보다 크거나 같다 (이상)
Console.WriteLine($"a == b : {a == b}"); // a가 b와 같다
Console.WriteLine($"a != b : {a != b}"); // a가 b와 다르다.

// 반대의 값들은 반대의 결과를 낸다.
// 만약 a < b의 결과 값이 false라면 a >= b는 true다.
// 만약 a == b의 결과 값이 false라면 a != b는 true다.
bool isTrue = a < b;
Console.WriteLine(isTrue);

    // 논리 연산자
// 양 측의 결과를 비교한다.

// 어떠한 값이 20보다 크고 30보다 작은가?
// a && b (AND) : a와 b의 값이 모두 참일 때 참이다.
// a || b (OR): a가 참이거나 b가 참일 경우 참이다.
// !a (NOT) : a의 결과값이 반대가 된다.

int level = 30;

// 어떠한 던전의 진입 레벨이 20~40까지일 때
Console.WriteLine($"던전의 적정 레벨은 20~40");
Console.WriteLine($"나의 레벨은 : {level}");
Console.WriteLine($"던전에 입장이 가능한가 : {20 <= level && level <= 40}");
Console.WriteLine($"나의 레벨은 : {41}");
Console.WriteLine($"던전에 입장이 가능한가 : {20 <= 41 && 41 <= 40}");

int level2 = 10;
// 나의 레벨이 10 혹은 20일 때 어떠한 이벤트가 일어난다고 생각해보자
Console.WriteLine($"이벤트가 일어나는가 : {level2 == 10 || level2 == 20}");


    // if문 (조건문)
if(level2 <= 10)
{
    Console.WriteLine("10레벨 이하입니다.");
}
else
{
    Console.WriteLine("10레벨 이상입니다.");
}


// Q. 나의 점수를 생성하고 해당 점수가 60점 이상인지 체크해보자
int myscore = 60;

if(myscore >= 60)
{
    if (myscore == 100)
    {
        Console.WriteLine("만점입니다.");
    }
    else
    
        Console.WriteLine("합격입니다.");
    
}
else if (myscore < 60)
{
    Console.WriteLine("불합격입니다.");
}
else
{
    Console.WriteLine("비정상적인 접근");
}


// 100~80 : a / 79~50 : b / 49~ : c
int myscore2 = 79;

if (100 >= myscore2 && myscore2 >= 80)
{
    Console.WriteLine("A");
}
else if(80 > myscore2 && myscore2 >= 50)
{
    Console.WriteLine("B");
}
else if (50 > myscore2 && myscore2 >= 0)
{
    Console.WriteLine("C");
}
else
{
    Console.WriteLine("ERROR");
}
*/

// 3교시

    // 조건(삼합) 연산자
    // = (조건식) ? A:B (조건식이 참이라면 A, 거짓이라면 B)

// 나의 레벨이 30이하일 때 "초보자", 아니라면 "일반"이라고 출력하고 싶다.

int user = 30;
// 1.
if(user > 30)
{
    Console.WriteLine("일반");
}
else if (user <= 30)
{
    Console.WriteLine("초보자");
}
else
{
    Console.WriteLine("error");
}

// 2.
string message = user <= 30 ? "초보자" : "일반";
Console.WriteLine(message);

// 3.
Console.WriteLine(user <= 30 ? "초보자" : "일반");

    // 비트 연산자
    // = 가장 작은 저장 단위인 비트 데이터를 다루는 연산자
    
    // 시프트 연산자
    // <<, >> : 모든 비트 배열을 왼쪽 혹은 오른쪽으로 n만큼 움직인다.
    // 비트는 2진수이므로 왼쪽으로 이동 할 수록 2배씩 증가한다. 오른쪽은 1/2

byte card = 1;
Console.WriteLine($"card << 1 : {card << 1}");
Console.WriteLine($"card << 2 : {card << 2}");
Console.WriteLine($"card >> 1 : {card >> 1}");

byte card2 = 255;
card2 = (byte)(card2 << 1); // 오버플로우를 일으킴. card2 << 1만 쓴다면 int형으로 변경 됨.
Console.WriteLine($"card2 << 1 : {card2}");

    // 비트 논리 연산자
    // & (AND) : 두 피연산자의 값이 1일 경우에 1이다.
    // | (OR) : 두 피연산자의 값이 하나라도 1일 경우에 1이다.
    // ^ (XOR) : 두 피연산자가 다를 경우에 1이다.
    // ~ (NOT) : 1을 0으로 0을 1로 변경한다.

byte byte1 = 3; // 0011
byte byte2 = 6; // 0110
Console.WriteLine($"0011 & 0110 {byte1 & byte2}");
Console.WriteLine($"0011 | 0110 {byte1 | byte2}");
Console.WriteLine($"0011 ^ 0110 {byte1 ^ byte2}");
Console.WriteLine($"~0011 {~byte1}"); // 패딩이 안드감

int ab1 = 10;
int ab2 = 20;

    // 할당 연산자 (복합 연산자)
    // ( +=, -=, *=, /=, *=, %=, &=, |=,^=, <<=, >>= )
// ab1에 ab1과 ab2의 더한 값을 대입하고 싶다.
ab1 += ab2; // = (ab1 = ab1 + ab2;)

    // !(NOT) 연산자 : 반대
Console.WriteLine($"1과 0은 같은가? 의 반대 { !(1 == 0)}");
