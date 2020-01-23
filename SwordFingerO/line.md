7. 重建二叉树 -> https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/
8.
9.
10.
11.
12. √矩阵中的路径 -> https://leetcode.com/problems/word-search/
13. 机器人的运动范围 -> 没找到
14. 剪绳子（dp） -> 没找到 
15. √二进制中1的个数 -> https://leetcode.com/problems/number-of-1-bits/ ->（升级版）https://leetcode.com/problems/counting-bits/
16. √数值的整数次方（溢出） -> https://leetcode.com/problems/powx-n/
17. 打印从1到最大的n位数（溢出） -> 没找到
18. √删除链表的节点 ->（简单版）https://leetcode.com/problems/delete-node-in-a-linked-list/ ->（升级版）https://leetcode.com/problems/remove-linked-list-elements 
19. ×正则表达式匹配 -> https://leetcode.com/problems/regular-expression-matching/
20. ×表示数值的字符串 -> https://leetcode.com/problems/valid-number/
21. √调整数组顺序使奇数在偶数前 -> https://leetcode.com/problems/sort-array-by-parity
22. √链表中倒数第K个节点 -> https://leetcode.com/problems/remove-nth-node-from-end-of-list/
23. √链表中环的入口节点 -> https://leetcode.com/problems/linked-list-cycle-ii
24. √反转链表 -> 只用了递归，下次用循环 https://leetcode.com/problems/reverse-linked-list/
25. √合并两个排序的链表 -> https://leetcode.com/problems/merge-two-sorted-lists/
26. √树的子结构 -> * https://leetcode.com/problems/subtree-of-another-tree/
27. √二叉树的镜像 -> https://leetcode.com/problems/invert-binary-tree
28. √对称的二叉树 -> https://leetcode.com/problems/symmetric-tree/
29. √顺时针打印矩阵 -> https://leetcode.com/problems/spiral-matrix/
30. √包含min函数的栈 -> https://leetcode.com/problems/min-stack/
31. √栈的压入、弹出序列 ->* https://leetcode.com/problems/validate-stack-sequences/
32. √从上到下打印二叉树 -> https://leetcode.com/problems/binary-tree-level-order-traversal/ -> 从下到上 https://leetcode.com/problems/binary-tree-level-order-traversal-ii/ -> 之字形打印 https://leetcode.com/problems/binary-tree-zigzag-level-order-traversal/
33. 二叉搜索树的后序遍历序列 -> *（只有先序遍历）https://leetcode.com/problems/verify-preorder-serialization-of-a-binary-tree/
34. √二叉树中和为某一值得路径 -> https://leetcode.com/problems/path-sum/
35. √复杂链表的复制 -> https://leetcode.com/problems/copy-list-with-random-pointer/
36. √二叉搜索树与双向链表 -> *（收费）https://leetcode.com/problems/convert-binary-search-tree-to-sorted-doubly-linked-list/ -> （牛客网）https://www.nowcoder.com/practice/947f6eb80d944a84850b0538bf0ec3a5?tpId=13&tqId=11179&tPage=1&rp=1&ru=/ta/coding-interviews&qru=/ta/coding-interviews/question-ranking
37. √序列化二叉树 -> https://leetcode.com/problems/serialize-and-deserialize-binary-tree/
38. √字符串的排列 -> （原理相同，leetcode用的数组）https://leetcode.com/problems/permutations/ ->(有重复元素的情况) https://leetcode.com/problems/permutations-ii
39. √数组中出现次数超过一半的数字 -> https://leetcode.com/problems/majority-element/ -> （升级版） https://leetcode.com/problems/majority-element-ii/
40. √最小的k个数 -> *（类似）https://leetcode.com/problems/kth-largest-element-in-an-array/
41. √数据流中的中位数 -> * https://leetcode.com/problems/find-median-from-data-stream/
42. √连续子数组的最大和 -> https://leetcode.com/problems/maximum-subarray/
43. √1~n整数中1出现的次数 -> https://leetcode.com/problems/number-of-digit-one/submissions/
44. √数字序列中某一位的数字 -> https://leetcode.com/problems/nth-digit/
45. √把数组排成最小的数 -> https://leetcode.com/problems/largest-number/
46. √把数字翻译成字符串 -> (递归or动归) https://leetcode.com/problems/decode-ways/
47. 礼物最大值 -> 未找到
48. √最长不含重复字符的子字符串 -> https://leetcode.com/problems/longest-substring-without-repeating-characters/
49. √丑数 -> （有更好的解法）https://leetcode.com/problems/ugly-number-ii/
50. √第一个只出现一次的字符 ->  https://leetcode.com/problems/first-unique-character-in-a-string/
51. 数组中的逆序对 -> （升级版）https://leetcode.com/problems/reverse-pairs/#/description
52. √两个链表的第一个公共节点 -> https://leetcode.com/problems/intersection-of-two-linked-lists/
53. √在排序数组中查找数字 -> https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/submissions/
54. 二叉搜索树的第K大节点 -> https://leetcode.com/problems/kth-smallest-element-in-a-bst/description/
55. 二叉树的深度 -> https://leetcode.com/problems/maximum-depth-of-binary-tree/
56. 数组中数字出现的次数 -> https://leetcode.com/problems/single-number-iii/
57. 和为S的数字 —> https://leetcode.com/problems/two-sum/
58. 翻转字符串 -> https://leetcode.com/problems/reverse-words-in-a-string/
59. 队列的最大值 ->


60. 2020/1/10 理论二：为了保证重构不出错，有哪些非常能落地的技术手段？
1. 什么是单元测试？
    确保代码的正确性，是否达到预期的结果
2. 为什么要买单元测试？
    1). 单元测试能有效地帮你发现代码中的bug
    2). 写单元测试能帮助发现代码设计上的问题
    3). 单元测试中的一些边界条件，异常情况下对集成测试的有力补充
    4). 写单元测试的过程本身就是代码重构的过程
    5). 阅读单元测试能帮助快速熟悉代码
    6). 单元测试是TDD可落地执行的改进方案
3. 如何编写单元测试
    只关心被测试函数实现的是什么功能，而不针对实现逻辑编写单元测试
    稍稍放低对单元测试代码质量的要求，覆盖率不是唯一指标
    单元测试框架无法测试，多半是因为代码的可测性不好。
Q： 写一个二分查找的变体算法，查找递增数组中第一个大于等于某个给定值的元素，并且为你的代码设计完备的单元测试用例

61. 2020/1/13 理论四：如何通过封装 抽象 模块化 中间层等解耦代码？
1. 代码是否需要解耦
    可以在阅读代码时候，将模块与模块之间，类与类之间的依赖关系画出来 根据依赖关系图的复杂性来判断是否需要解耦重构
2. 如何给代码"解耦"
    1).封装与抽象
        隐藏实现的复杂性，隔离实现的易变性，给依赖的模块提供稳定且易用的抽象接口
    2).中间层
        进行重构时，引入中间层可以起到过度的作用，能够让开发和重构同步进行。
        分四个阶段完成接口的修改  1.引入中间层包裹老接口 提供新的接口定义
        2. 新开发的代码依赖中间层提供的新接口
        3. 将依赖的老接口的代码改为调用新接口
        4. 确保所有的diamagnetic都调用新接口之后，删除老接口
    3).模块化
62. 2020/1/13 AC自动机：如何用多模式串匹配实现敏感词过滤功能？ 
1. 多模式串匹配算法   --高性能敏感词过滤系统
    AC 自动机是基于 Trie 树的一种改进算法，它跟 Trie 树的关系，就像单模式串中，KMP 算法与 BF 算法的关系一样。KMP 算法中有一个非常关键的 next 数组，类比到 AC 自动机中就是失败指针。而且，AC 自动机失败指针的构建过程，跟 KMP 算法中计算 next 数组极其相似。所以，要理解 AC 自动机，最好先掌握 KMP 算法，因为 AC 自动机其实就是 KMP 算法在多模式串上的改造。
    整个 AC 自动机算法包含两个部分，第一部分是将多个模式串构建成 AC 自动机，第二部分是在 AC 自动机中匹配主串。第一部分又分为两个小的步骤，一个是将模式串构建成 Trie 树，另一个是在 Trie 树上构建失败指针。

63. 2020/1/14 红黑树(上)：为什么工程中都用红黑树这种二叉树？
1. 平衡二叉树严格定义是二叉树中的任意一个节点的左右子树的高度相差不能大于1
2. 红黑树需要满足以下要求 ：1.根节点是黑色的； 2.每个叶子节点都是黑色的空节点，不存储数据 3.任何相邻的节点都不能同时为红色 4.每个节点从该节点到达其可达叶子节点的所有路径，都包含相同数目的黑色节点
    红黑树的插入 删除 查找各种操作的时间复杂度都相对稳定，出现异常情况的可能较小

64. 2020/1/15 红黑树(下)：掌握这些技巧，你也可以实现一个红黑树
1. 左旋(rotate left) 右旋
总结 把红黑树的平衡调整的过程比作魔方复原，不要过于深究这个算法的正确性。只要按照固定的操作步骤，保持插入 删除的过程 不破坏平衡树的定义即可
     找准关注节点，不要搞丢 搞错关注节点
     插入操作的平衡调整比较简单 但是删除操作比较复杂


65. 2020/1/16 理论五：让你最快速地改善代码质量的20条编程规范(中)
1. 代码风格
    1. 函数/类多大才合适
    函数的代码行数不要超过一屏幕的大小。大小限制看情况吧
    2.一行代码多长最合适
    最好不要超过IDE显示的宽度，限制也不能太小。适中即可
    3.善用空格分隔单元块
    4.四格缩进还是两格缩进
    5.大括号是否要另起一行？
    6.类中成员的排列顺序

66. 2020/1/20 理论五：让你最快速地改善代码质量的20条编程规范(下)
1. 把代码分割为更小的单元块
2. 避免函数参数过多
    1.考虑函数是否职责单一
    2.将函数的参数封装成对象
        如果函数是对外暴露的远程接口，将参数封装成对象，还可以提高接口的兼容性
3. 勿用函数参数来控制逻辑
    true走这块逻辑 ，false走另一块逻辑。明显违反单一职责原则和接口隔离原则。
    可以拆成两个函数，可读性上也更好
4. 函数设计要职责单一
5. 移除过深的嵌套层次
    去除多余的if else 语句，使用break/continuc/return关键字提前退出嵌套  调整执行顺序来减少嵌套   将部分嵌套逻辑抽象成函数
6. 使用解释型变量 使用字面常量取代魔数或者用解释型变量来解释复杂表达式，以此来提高代码可读性

67. 2020/1/20 算法实战(二): 刨析搜索引擎背后经典数据结构和算法
1. 搜索引擎大致可以分为四个部分：搜集 分析 索引 查询


68. 2020/1/21 实战一(上):通过一段ID生成器代码，学习如何发现代码质量问题
1. 可以从以下方面评判代码是否可读 可扩展 可维护 灵活 简洁 可复用 可测试等等
  1. 目录设置是否合理 模块划分是否清晰 代码结构是否满足"高内聚 低耦合"
  2. 是否遵循经典的设计原则和设计思想(SOLID,DRY,KISS,YAGNI,LOD等)
  3. 设计模式是否应用得当?是否有过度设计
  4. 代码是否容易拓展？如果要添加新功能，是否容易实现?
  5. 代码是否可以复用？是否可以复用已有的项目代码或类库？是否重复造轮子
  6. 代码是否容易测试？单元测试是否全面覆盖了各种正常和异常的情况?
  7. 代码是否易读？是否符合编码规范(比如命名和注释是否恰当 代码风格是否一致等)？
    还需要关注代码实现是否满足业务本身特有的功能和非功能需求。一些共性问题
    1. 代码是否实现了预期的业务需求?
    2. 逻辑是否正确？是否处理了各种异常情况？
    3. 日志打印是否得当?是否方便debug排查问题？
    4. 接口是否易用？是否支持幂等 事务等？
    5. 代码是否存在并发问题？是否线程安全？
    6. 性能是否有优化空间，比如 SQL 算法是否可以优化？
    7. 是否有安全漏洞？比如输入输出校验是否全面？

69. 2020/1/21 基础架构:一条SQL查询语句是如何执行的？
1. MySQL基础架构
  客户端->连接器->[查询缓存->]分析器->优化器->执行器->存储引擎
  create table默认使用InnoDB 可以显式指定 engine = memory
  连接器
    连接命令 ： mysql -h$ip -P$port -u$user -p
    user权限依赖于连接时读取到的权限
    连接参数   wait_timeout
    长连接累计太多导致内存占用太大 被系统强行杀掉(OOM) 从现象看就是MySQL异常重启了
    如何解决
    1. 定期断开长连接。使用一段时间，或者程序里判断执行过一个占用内存的大查询后，断开连接，之后要查询再重连
    2. MySQL 5.7^ 可以在每次执行比较大的操作后，通过mysql_reset_connection来重新初始化连接资源。这个过程不需要重连和重新做权限验证，但是会将连接恢复到刚刚创建完时的状态
  查询缓存
    不建议使用，往往利大于弊
    常常在更新一个值后，所有的查询缓存都将失效
  分析器
    词法分析->语法分析
  优化器
  执行器
    开始执行前 先判断一下对表是否有权限
    慢查询日志 row_examined 表示扫描了多少行

70. 日志系统：一条SQL更新语句是如何执行的？
  更新流程     redo log && binlog
    **redo log   存储引擎层  InnoDB特有   物理页变更信息日志
    WAL   --  Write-Ahead Logging 先写日志 再写磁盘
    write pos && checkpoint
    crash-safe
    **binlog      Server层    SQL语句信息 逻辑修改日志
    binlog没有被用来做崩溃恢复
    历史原因 + 操作上binlog可以被关闭   ->set sql_log_bin=0
  两阶段提交
    
    为该讲的内容总结了几个问题, 大家复习的时候可以先尝试回答这些问题检查自己的掌握程度:
   1. redo log的概念是什么? 为什么会存在.
   2. 什么是WAL(write-ahead log)机制, 好处是什么.
   3. redo log 为什么可以保证crash safe机制.
   4. binlog的概念是什么, 起到什么作用, 可以做crash safe吗?
   5. binlog和redolog的不同点有哪些?
   6. 物理一致性和逻辑一直性各应该怎么理解?
   7. 执行器和innoDB在执行update语句时候的流程是什么样的?
   8. 如果数据库误操作, 如何执行数据恢复?
   9. 什么是两阶段提交, 为什么需要两阶段提交, 两阶段提交怎么保证数据库中两份日志间的逻辑一致性(什么叫逻辑一致性)?
  10. 如果不是两阶段提交, 先写redo log和先写bin log两种情况各会遇到什么问题?

71. 2020/1/22 实战一(下)：手把手带你将ID生成器代码从"能用"重构为"好用"
  代码重构可以分为四轮
  1. 提高代码的可读性
  2. 提高代码的可测试性
  3. 编写完善的单元测试
  4. 所有重构完成之后添加注释

72. 2020/1/23 事务隔离：为什么你改了我还看不见？
  事务支持是在引擎层实现的，而且并不是所有引擎支持事务，MyISAM就不支持
  #隔离性与隔离级别
  ACID(Atomicity,Consistency,Isolation,Durability)
  隔离性  --多个事务同时执行时 可能出现脏读(dirty-read) 不可重复读(non-repeatable read) 幻读(phantom read)等问题
  SQL事务隔离级别包括：读未提交(read uncommitted) 读提交(read committed) 可重复读(repeatable read) 串行化(serializable)
  实现上，数据库里创建一个视图，访问的时候以视图的逻辑结果为准。
  [可重复读]的视图在事务启动时创建，整个事务存在期间都用这个视图
  [读提交]在每个SQL语句开始执行的时候创建
  [读未提交]直接返回记录上的最新值 没有视图概念
  [串行化]直接用加锁的方式来避免并行访问
  Oracle 默认隔离级别是读提交 Mysql 可重复读
  show variables like 'transaction_isolation';
  查询长事务
  select * from information_schema.innodb_trx where TIME_TO_SEC(timediff(now(),trx_started))>60
