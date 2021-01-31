using System.Collections.Generic;

public class POIListResult {
    public int? count { get; set; }
    public IEnumerable<OCM.API.Common.Model.ChargePoint> poiList { get; set; }

    public POIListResult(IEnumerable<OCM.API.Common.Model.ChargePoint> list) {
        this.poiList = list;
    }
    public POIListResult(int count) {
        this.count = count;
    }

}
