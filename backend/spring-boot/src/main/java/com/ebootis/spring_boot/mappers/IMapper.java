package com.ebootis.spring_boot.mappers;

public interface IMapper<Entity, DTO> {
    DTO toDTO(Entity entity);
    Entity toEntity(DTO dto);
}
