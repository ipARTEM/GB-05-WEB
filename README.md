������ 1

����������, ��� �� �������� � api ������� ������. ����� ���� ���������� ������ �������� ��������� ������ �����,
���������� ���������� ������ � �������� ��������� � ��������� ����.

����� ��������� ����� ����������� ��������� �������: GET /posts/{id}, ��� id - ������������� �����.

������ ������:

{
  "userId": 2,
  "id": 14,
  "title": "voluptatem eligendi optio",
  "body": "fuga et accusamus dolorum perferendis illo"
}



���������� �������� ���������� ����������, ������� �������� ���������� 10 HTTP-�������� �� ��������� ������ �� �����,
�� �������������� ��������������, ������� � id=4 �� id=13. ��� ���������� �������� ���������� ������������
HttpClient (��. https://docs.microsoft.com/ru-ru/dotnet/api/system.net.http.httpclient?view=net-5.0).

� ���������� ������ ��������� ������ ���������� ��������� ���� ��� ��������� result.txt, 
� ������� ��������� ���������� ���������� � ������ � ��������� �������:

userId
id
title
body

����� ������� ������������ ������. ���, ���������� ����� ����� ��������� ��������� �������:

1
4
eum et est occaecati
ullam et saepe reiciendis voluptatem adipisci\nsit amet autem assumenda provident rerum culpa\nquis hic commodi nesciunt rem tenetur doloremque ipsam iure\nquis sunt voluptatem rerum illo velit

1
5
nesciunt quas odio
repudiandae veniam quaerat sunt sed\nalias aut fugiat sit autem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest aut tenetur dolor neque


����� � ����� ������ ��������� 10 ������.

