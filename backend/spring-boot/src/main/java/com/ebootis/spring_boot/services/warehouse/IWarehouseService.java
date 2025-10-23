package com.ebootis.spring_boot.services.warehouse;

import com.ebootis.spring_boot.dtos.WareHouseDTO;
import com.ebootis.spring_boot.models.Warehouse;
import com.ebootis.spring_boot.services.generic.ICombinedGenericService;


public interface IWarehouseService extends ICombinedGenericService<Warehouse, WareHouseDTO,Integer> {

}
