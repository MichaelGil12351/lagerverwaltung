package com.ebootis.spring_boot.mappers;

import com.ebootis.spring_boot.dtos.WareHouseDTO;
import com.ebootis.spring_boot.models.Warehouse;
import org.springframework.stereotype.Component;

@Component
public class LocationMapper implements IMapper<Warehouse, WareHouseDTO> {

    @Override
    public WareHouseDTO toDTO(Warehouse p_locationEntity) {
        if (p_locationEntity == null) return null;
        WareHouseDTO locationDTO = new WareHouseDTO();
        locationDTO.setId(p_locationEntity.getId());
        locationDTO.setName(p_locationEntity.getName());
        locationDTO.setMaxCapacity(p_locationEntity.getMaxCapacity());
        return locationDTO;
    }

    @Override
    public Warehouse toEntity(WareHouseDTO p_locationDTO) {
        if (p_locationDTO == null) return null;
        Warehouse location = new Warehouse();
        location.setId(p_locationDTO.getId());
        location.setName(p_locationDTO.getName());
        location.setMaxCapacity(p_locationDTO.getMaxCapacity());
        return location;
    }
}
