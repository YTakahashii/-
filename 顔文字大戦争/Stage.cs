using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 顔文字大戦争
{
    public interface IStage
    {
        Enemy CreateEnemy();
        Structure CreateStructure(int x, int y, bool isPlayer);
        int getExp();
        bool NewCharacter();
        Player getNewCharacter();
        int exsistEnemyNum{get; set;}
    }

    public abstract class Stage : IStage
    {
        protected int EXP = 0;
        private int createNum, BossCharaNum, createBossNum;
        protected int maxCreateEnemyNum = 0;
        protected Player newCharacter = null;
        protected Enemy normalEnemy = null, bossEnemy = null;
        public int exsistEnemyNum{get; set;}
        protected int ExsistAllowNum = 6;
        protected int structureHP = 0;

        protected abstract void Init(int stageLevel);

        protected Stage(int stageLevel)
        {
            exsistEnemyNum = 0;
            createNum = 0;
            createBossNum = 0;
            BossCharaNum = stageLevel+1;
            ExsistAllowNum += stageLevel;
        }

        public Enemy CreateEnemy()
        {
            Enemy enemy = null;
            if(exsistEnemyNum < ExsistAllowNum){
                if(createNum <= maxCreateEnemyNum){
                    enemy = normalEnemy;
                    normalEnemy = normalEnemy.Refresh();
                    exsistEnemyNum++;
                    createNum++;
                }else if(createBossNum <= BossCharaNum){
                    enemy = bossEnemy;
                    bossEnemy = bossEnemy.Refresh();
                    exsistEnemyNum++;
                    createBossNum++;
                }
            }
            return enemy;
        }

        public Structure CreateStructure(int x, int y, bool isPlayer)
        {
            return new Structure1(x, y, isPlayer, structureHP);
        }

        public int getExp()
        {
            return EXP;
        }

        public bool NewCharacter()
        {
            if(newCharacter != null){
                return true;
            }else{
                return false;
            }
        }

        public Player getNewCharacter()
        {
            return newCharacter;
        }
    }

    public class Stage1 : Stage
    {
        public Stage1(int stageLevel) : base(stageLevel)
        {
            Init(stageLevel);
        }

        protected override void Init(int stageLevel)
        {
            base.EXP = 1000 + stageLevel * 70;
            base.structureHP = 300;
            base.ExsistAllowNum = 5;
            base.maxCreateEnemyNum = 10 + stageLevel * 3;
            base.newCharacter = new PlayerChara2();
            if(stageLevel <= 5 ){
                base.normalEnemy = new EnemyChara1();
                base.bossEnemy = new EnemyChara2();
            }else{
                base.normalEnemy = new EnemyChara1Ex();
                base.bossEnemy = new EnemyChara2Ex();
            }   
        }
    }

    public class Stage2 : Stage
    {
        public Stage2(int stageLevel) : base(stageLevel)
        {
            Init(stageLevel);
        }

        protected override void Init(int stageLevel)
        {
            base.EXP = 2000 + stageLevel * 500;
            base.structureHP = 400;
            base.ExsistAllowNum = 5;
            base.maxCreateEnemyNum = 10 + stageLevel * 3;
            base.newCharacter = new PlayerChara3();
            if(stageLevel <= 5 ){
                base.normalEnemy = new EnemyChara1();
                base.bossEnemy = new EnemyChara3();
            }else{
                base.normalEnemy = new EnemyChara2Ex();
                base.bossEnemy = new EnemyChara3Ex();
            }   
        }
    }

    public class Stage3 : Stage
    {
        public Stage3(int stageLevel) : base(stageLevel)
        {
            Init(stageLevel);
        }

        protected override void Init(int stageLevel)
        {
            base.EXP = 3000 + stageLevel * 500;
            base.structureHP = 500;
            base.ExsistAllowNum = 6;
            base.maxCreateEnemyNum = 12 + stageLevel * 3;
            base.newCharacter = null;
            if(stageLevel <= 5 ){
                base.normalEnemy = new EnemyChara1Ex();
                base.bossEnemy = new EnemyChara4();
            }else{
                base.newCharacter = new PlayerChara7();
                base.normalEnemy = new EnemyChara3Ex();
                base.bossEnemy = new EnemyChara4Ex();
            }
        }
    }

    public class Stage4 : Stage
    {
        public Stage4(int stageLevel) : base(stageLevel)
        {
            Init(stageLevel);
        }

        protected override void Init(int stageLevel)
        {
            base.EXP = 4000 + stageLevel * 70;
            base.structureHP = 600;
            base.ExsistAllowNum = 6;
            base.maxCreateEnemyNum = 14 + stageLevel * 3;
            base.newCharacter = new PlayerChara11();
            if(stageLevel <= 5 ){
                base.normalEnemy = new EnemyChara3();
                base.bossEnemy = new EnemyChara5();
            }else{
                base.normalEnemy = new EnemyChara4();
                base.bossEnemy = new EnemyChara5Ex();
            }
        }
    }

    public class Stage5 : Stage
    {
        public Stage5(int stageLevel) : base(stageLevel)
        {
            Init(stageLevel);
        }

        protected override void Init(int stageLevel)
        {
            base.EXP = 5000 + stageLevel * 70;
            base.structureHP = 700;
            base.ExsistAllowNum = 6;
            base.maxCreateEnemyNum = 14 + stageLevel * 3;
            base.newCharacter = new PlayerChara4();
            if(stageLevel <= 5 ){
                base.normalEnemy = new EnemyChara4();
                base.bossEnemy = new EnemyChara5();
            }else{
                
                base.normalEnemy = new EnemyChara5();
                base.bossEnemy = new EnemyChara5Ex();
            } 
        }
    }

    public class Stage6 : Stage
    {
        public Stage6(int stageLevel) : base(stageLevel)
        {
            Init(stageLevel);
        }

        protected override void Init(int stageLevel)
        {
            base.EXP = 6000 + stageLevel * 70;
            base.structureHP = 800;
            base.ExsistAllowNum = 7;
            base.maxCreateEnemyNum = 16 + stageLevel * 3;
            base.newCharacter = new PlayerChara6();
            if(stageLevel <= 5 ){
                base.normalEnemy = new EnemyChara5();
                base.bossEnemy = new EnemyChara6();
            }else{
                base.newCharacter = new PlayerChara5();
                base.normalEnemy = new EnemyChara5();
                base.bossEnemy = new EnemyChara6Ex();
            }
        }
    }

    public class Stage7 : Stage
    {
        public Stage7(int stageLevel) : base(stageLevel)
        {
            Init(stageLevel);
        }

        protected override void Init(int stageLevel)
        {
            base.EXP = 7000 + stageLevel * 70;
            base.structureHP = 900;
            base.ExsistAllowNum = 7;
            base.maxCreateEnemyNum = 14 + stageLevel * 3;
            base.newCharacter = null;
            if(stageLevel <= 5 ){
                base.normalEnemy = new EnemyChara4Ex();
                base.bossEnemy = new EnemyChara5Ex();
            }else{
                base.newCharacter = new PlayerChara8();
                base.normalEnemy = new EnemyChara6();
                base.bossEnemy = new EnemyChara7Ex();
            }
        }
    }

    public class Stage8 : Stage
    {
        public Stage8(int stageLevel) : base(stageLevel)
        {
            Init(stageLevel);
        }

        protected override void Init(int stageLevel)
        {
            base.EXP = 8000 + stageLevel * 70;
            base.structureHP = 1000;
            base.ExsistAllowNum = 8;
            base.maxCreateEnemyNum = 16 + stageLevel * 3;
            base.newCharacter = new PlayerChara12();
            if(stageLevel <= 5 ){
                base.normalEnemy = new EnemyChara7();
                base.bossEnemy = new EnemyChara8();
            }else{
                base.newCharacter = new PlayerChara10();
                base.normalEnemy = new EnemyChara7Ex();
                base.bossEnemy = new EnemyChara8Ex();
            }
        }
    }

    public class Stage9 : Stage
    {
        public Stage9(int stageLevel) : base(stageLevel)
        {
            Init(stageLevel);
        }

        protected override void Init(int stageLevel)
        {
            base.EXP = 9000 + stageLevel * 70;
            base.structureHP = 1200;
            base.ExsistAllowNum = 8;
            base.maxCreateEnemyNum = 12 + stageLevel * 3;
            base.newCharacter = null;
            if(stageLevel <= 5 ){
                base.normalEnemy = new EnemyChara8();
                base.bossEnemy = new EnemyChara9();
            }else{
                base.newCharacter = new PlayerChara9();
                base.normalEnemy = new EnemyChara8Ex();
                base.bossEnemy = new EnemyChara9Ex();
            }
        }
    }

    public class Stage10 : Stage
    {
        public Stage10(int stageLevel) : base(stageLevel)
        {
            Init(stageLevel);
        }

        protected override void Init(int stageLevel)
        {
            base.EXP = 10000 + stageLevel * 70;
            base.structureHP = 1500;
            base.ExsistAllowNum = 9;
            base.maxCreateEnemyNum = 18 + stageLevel * 3;
            base.newCharacter = null;
            if(stageLevel <= 5 ){
                base.normalEnemy = new EnemyChara8();
                base.bossEnemy = new EnemyChara9Ex();
            }else{
                base.normalEnemy = new EnemyChara9();
                base.bossEnemy = new EnemyChara10();
            }
        }
    }
}