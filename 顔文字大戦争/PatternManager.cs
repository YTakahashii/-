using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 顔文字大戦争
{
    public class PatternManager
    {
        public PatternManager(){}

        public string getCharaPattern(string[] charaData, CharaDataIndex index)
        {
            string result = "";
            switch(index){
                case CharaDataIndex.Normal:
                    result = charaData[(int)CharaDataIndex.Normal];
                    break;
                case CharaDataIndex.Attack:
                    result = charaData[(int)CharaDataIndex.Attack];
                    break;
                case CharaDataIndex.Damege:
                    result = charaData[(int)CharaDataIndex.Damege];
                    break;
            }
            return result;
        }

        //アニメーションで数秒おきに自動で変わる
        public ActionStatus nextActionPattern(ActionStatus state, bool walkable)
        {
            ActionStatus next = ActionStatus.Wait;
            switch(state){
                case ActionStatus.Walk:
                    if(walkable){
                        next = ActionStatus.Walk;
                    }else{
                        next = ActionStatus.Wait;
                    }
                    break;
                case ActionStatus.Attack:
                    if(walkable){
                        next = ActionStatus.Walk;
                    }else{
                        next = ActionStatus.Wait;
                    }
                    break;
                case ActionStatus.Wait:
                    if(walkable){
                        next = ActionStatus.Walk;
                    }else{
                        next = ActionStatus.Attack;
                    }
                    break;
                case ActionStatus.Wince:
                    next = ActionStatus.Walk;
                    break;
                case ActionStatus.Dead:
                    next = ActionStatus.Dead;
                    break;
            }
            return next;
        }
    }
}
