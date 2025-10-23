package com.ebootis.spring_boot.services.generic;


import com.ebootis.spring_boot.mappers.IMapper;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;
import java.util.Optional;
import java.util.stream.Collectors;

public abstract class CombinedGenericServiceImpl<E, D, ID> implements ICombinedGenericService<E, D, ID> {

    protected final JpaRepository<E, ID> repository;
    protected final IMapper<E, D> mapper;

    public CombinedGenericServiceImpl(JpaRepository<E, ID> repository, IMapper<E, D> mapper) {
        this.repository = repository;
        this.mapper = mapper;
    }


    @Override
    public E create(E entity) {
        return repository.save(entity);
    }

    @Override
    public E update(E entity) {
        return repository.save(entity);
    }

    @Override
    public Optional<E> getById(ID id) {
        return repository.findById(id);
        //repository.getReferenceById()
    }

    @Override
    public List<E> getAll() {
        return repository.findAll();
    }

    @Override
    public void deleteById(ID id) {
        repository.deleteById(id);
    }

    // Métodos DTO
    @Override
    public List<D> getAllDTO() {
        return repository.findAll()
                .stream()
                .map(mapper::toDTO)
                .collect(Collectors.toList());
    }

    @Override
    public Optional<D> getDTOById(ID id) {
        if (id == null) return Optional.empty();
        return repository.findById(id).map(mapper::toDTO);
    }

    @Override
    public D createDTO(D dto) {
        E entity = mapper.toEntity(dto);
        E saved = repository.save(entity);
        return mapper.toDTO(saved);
    }
}

