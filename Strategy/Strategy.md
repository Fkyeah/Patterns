# Стратегия

[Проект](../Strategy/)

Определяет семейство алгоритмов, инкапсулирует каждый из них и обеспечивает взаимозаменяемость. Он позволяет модифицировать алгоритмы независимо от их использования на стороне клиента.

Отдаем предпочтение композиции перед наследованием 

Выделение аспектов приложения, которые могут изменяться, и отделение их от тех, которые всегда остаются постоянными.

Программирование на уровне интерфейсов.

В программе представлен симулятор пруда с утками.
Утки представлены следующими видами:
1) Дикая утка - имеет свой уникальный вид, летает, плавает, крякает.
2) Домашняя утка - имеет свой уникальный вид, летает, плавает, крякает.
3) Резиновая утка - имеет свой уникальный вид, не летает, плавает, пищит.
4) Деревянная утка - имеет свой уникальный вид, не летает, плавает, молчит.
