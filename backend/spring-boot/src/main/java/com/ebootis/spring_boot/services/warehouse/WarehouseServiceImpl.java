package com.ebootis.spring_boot.services.warehouse;

import com.ebootis.spring_boot.dtos.WareHouseDTO;
import com.ebootis.spring_boot.mappers.IMapper;
import com.ebootis.spring_boot.models.Warehouse;
import com.ebootis.spring_boot.services.generic.CombinedGenericServiceImpl;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Service;

@Service
public class WarehouseServiceImpl extends CombinedGenericServiceImpl<Warehouse, WareHouseDTO,Integer> implements IWarehouseService {

    public WarehouseServiceImpl(JpaRepository<Warehouse, Integer> repository, IMapper<Warehouse, WareHouseDTO> mapper) {
        super(repository, mapper);
    }
}
